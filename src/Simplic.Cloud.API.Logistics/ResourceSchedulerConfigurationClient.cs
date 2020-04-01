using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Contact client. This api client contains all general and data port specific methods.
    /// </summary>
    public class ResourceSchedulerConfigurationClient : CRUDClientBase<ConfigurationModel, Guid>
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public ResourceSchedulerConfigurationClient()
            : base()
        {

        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public ResourceSchedulerConfigurationClient(string url)
            : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public ResourceSchedulerConfigurationClient(IClient client)
            : base(client)
        {

        }

        public virtual async Task<IList<ConfigurationModel>> GetAllAsync()
        {
            return await base.GetAsync<IList<ConfigurationModel>>(Api, Controller, "get-all", new Dictionary<string, string> { });
        }

        protected override string Api => "resource-scheduler";

        protected override string Controller => "configuration";
    }
}
