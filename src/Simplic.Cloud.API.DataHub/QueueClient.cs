using System;

namespace Simplic.Cloud.API.DataHub
{
    /// <summary>
    /// Data hub queue client
    /// </summary>
    public class QueueClient : CRUDClientBase<QueueModel, Guid>
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public QueueClient()
            : base()
        {

        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public QueueClient(string url)
            : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public QueueClient(IClient client)
            : base(client)
        {

        }

        /// <summary>
        /// Gets the api name (hr)
        /// </summary>
        protected override string Api => "data-hub";

        /// <summary>
        /// Gets the controller name (employee)
        /// </summary>
        protected override string Controller => "queue";
    }
}
