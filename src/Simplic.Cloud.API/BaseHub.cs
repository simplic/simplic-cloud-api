using Microsoft.AspNetCore.SignalR.Client;
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
    public class BaseHub : IDisposable
    {
        private HubConnection connection;
        private ClientBase clientBase;

        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public BaseHub(string api, string hubName, ClientBase clientBase)
        {
            this.clientBase = clientBase ?? throw new ArgumentNullException(nameof(clientBase));

            if (string.IsNullOrWhiteSpace(clientBase.User?.Token))
                throw new Exception("User not logged in.");

            connection = new HubConnectionBuilder()
                .WithUrl($"{clientBase.Url}/{ClientBase.ApiVersion}/{api}-api/{hubName}", options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(clientBase.User.Token);
                })
                .Build();
        }

        /// <summary>
        /// Dispose connection
        /// </summary>
        public void Dispose()
        {
            // Dispose connection
            Task.Run(async () =>
            {
                await connection.StopAsync();
                await connection.DisposeAsync();
            });
        }
    }
}
