using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.DataHub
{
    /// <summary>
    /// Event queue client
    /// </summary>
    public class EventQueueClient : ClientBase
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public EventQueueClient()
            : base()
        {

        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public EventQueueClient(string url)
            : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public EventQueueClient(IClient client)
            : base(client)
        {

        }

        public async Task<IList<QueueEntryModel>> GetAsync(Guid queueId, int chunkSize)
        {
            return await GetAsync<IList<QueueEntryModel>>(Api, Controller, "get", new Dictionary<string, string>
            {
                { "queueId", $"{queueId}" },
                { "chunkSize", $"{chunkSize}" }
            });
        }

        public async Task EnqueueAsync(EnqueueModel model)
        {
            await PostAsync<object, EnqueueModel>(Api, Controller, "enqueue", model);
        }

        public async Task<int> CountAsync(Guid queueId)
        {
            return await GetAsync<int>(Api, Controller, "count", new Dictionary<string, string>
            {
                { "queueId", $"{queueId}" }
            });
        }

        public async Task CommitAsync(CommitModel model)
        {
            await PostAsync<object, CommitModel>(Api, Controller, "commit", model);
        }

        /// <summary>
        /// Gets the api name (hr)
        /// </summary>
        protected string Api => "data-hub";

        /// <summary>
        /// Gets the controller name (employee)
        /// </summary>
        protected string Controller => "event-queue";
    }
}
