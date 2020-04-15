using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API
{
    /// <summary>
    /// Basic hub integration
    /// </summary>
    public abstract class BaseHub : IDisposable
    {
        private ClientBase clientBase;

        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public BaseHub(string api, string hubName, ClientBase clientBase)
        {
            this.clientBase = clientBase ?? throw new ArgumentNullException(nameof(clientBase));

            if (string.IsNullOrWhiteSpace(clientBase.User?.Token))
                throw new Exception("User not logged in.");

            Connection = new HubConnectionBuilder()
                .WithUrl($"{clientBase.Url}/{ClientBase.ApiVersion}/{api}-api/{hubName}", options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(clientBase.User.Token);
                })
                .WithAutomaticReconnect()
                .Build();

            Connection.ServerTimeout = TimeSpan.FromSeconds(30);
            Connection.KeepAliveInterval = TimeSpan.FromMilliseconds(100);

            Connection.Closed += ConnectionClosedEventHandler;
            Connection.Reconnected += ConnectionReconnectedEventHandler;
            Connection.Reconnecting += ConnectionReconnectingEventHandler;
        }

        private async Task ConnectionReconnectingEventHandler(Exception arg)
        {
            await ConnectionReconnecting(arg);
        }

        private async Task ConnectionReconnectedEventHandler(string arg)
        {
            await ConnectionReconnected(arg);
        }

        private async Task ConnectionClosedEventHandler(Exception arg)
        {
            await ConnectionClosed(arg);
        }

        public virtual async Task ConnectionReconnecting(Exception ex)
        { 
            
        }

        public virtual async Task ConnectionReconnected(string arg)
        {

        }

        public virtual async Task ConnectionClosed(Exception ex)
        {

        }

        /// <summary>
        /// Start connection async
        /// </summary>
        /// <returns></returns>
        public async Task StartAsync()
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
        }

        /// <summary>
        /// Dispose connection
        /// </summary>
        public virtual void Dispose()
        {
            // Dispose connection
            Task.Run(async () =>
            {
                await Connection.StopAsync();
                await Connection.DisposeAsync();
            });
        }

        /// <summary>
        /// Gets the HubConnection
        /// </summary>
        protected HubConnection Connection { get; private set; }
    }
}
