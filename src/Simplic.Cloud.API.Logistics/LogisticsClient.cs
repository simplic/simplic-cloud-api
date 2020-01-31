using Simplic.Cloud.ResourceScheduler.Api.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Data port client. This api client contains all general and data port specific methods.
    /// </summary>
    public class LogisticsClient : ClientBase
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public LogisticsClient()
            : base()
        {

        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public LogisticsClient(string url)
            : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public LogisticsClient(IClient client)
            : base(client)
        {

        }

        /// <summary>
        /// Create resource scheduler configuration
        /// </summary>
        /// <param name="email">User account mail address</param>
        /// <param name="password">User account password</param>
        /// <returns>Instance of <see cref="User"/> if login was successful</returns>
        /// <exception cref="ApiException">If the login process fails</exception>
        public async Task<ConfigurationModel> CreateResourceSchedulerAsync(string organizationId, string name)
        {
            return await PostAsync<ConfigurationModel, ConfigurationModel>("resource-scheduler", "configuration", "create", new ConfigurationModel
            {
                OrganizationId = organizationId,
                Name = name
            });
        }
    }
}
