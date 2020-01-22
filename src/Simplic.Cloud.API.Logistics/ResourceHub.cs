using Microsoft.AspNetCore.SignalR.Client;
using Simplic.Cloud.ResourceScheduler.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Resource hub
    /// </summary>
    public abstract class ResourceHub : BaseHub
    {
        private readonly IList<IDisposable> receiver = new List<IDisposable>();

        /// <summary>
        /// Resource hub
        /// </summary>
        /// <param name="clientBase"></param>
        public ResourceHub(ClientBase clientBase) : base("resource-scheduler", "resource", clientBase)
        {
            receiver.Add(Connection.On<ResourceBaseModel>("PushAddResourceAsync", OnAddResourceAsync));
            receiver.Add(Connection.On<IList<ResourceBaseModel>>("PushAddResourcesAsync", OnAddResourcesAsync));
            receiver.Add(Connection.On<Guid>("PushRemoveResourceAsync", OnRemoveResourceAsync));
            receiver.Add(Connection.On<ResourceBaseModel>("PushUpdateResourceAsync", OnUpdateResourceAsync));
        }

        #region [Request]
        /// <summary>
        /// Reqeust resources
        /// </summary>
        public async Task RequestResourcesAsync(GetResourceRequest request)
        {
            await Connection.SendAsync(nameof(RequestResourcesAsync), request);
        }

        /// <summary>
        /// Add resource request
        /// </summary>
        public async Task AddResourceAsync(AddResourceRequest request)
        {
            await Connection.SendAsync(nameof(AddResourceAsync), request);
        }

        /// <summary>
        /// Remove resource
        /// </summary>
        /// <param name="request">Request type</param>
        /// <returns></returns>
        public async Task RemoveResourceAsync(RemoveResourceRequest request)
        {
            await Connection.SendAsync(nameof(RemoveResourceAsync), request);
        }
        #endregion

        #region [Response]
        /// <summary>
        /// Push add resource
        /// </summary>
        /// <param name="resource">Added resource</param>
        /// <returns>Resource object</returns>
        protected abstract Task OnAddResourceAsync(ResourceBaseModel resource);

        /// <summary>
        /// Pushes a list of resources
        /// </summary>
        /// <param name="resources">Resources</param>
        protected abstract Task OnAddResourcesAsync(IList<ResourceBaseModel> resources);

        /// <summary>
        /// Push remove resource
        /// </summary>
        /// <param name="resourceId">Resource id</param>
        protected abstract Task OnRemoveResourceAsync(Guid resourceId);

        /// <summary>
        /// Push update resource
        /// </summary>
        /// <param name="resource">Resource</param>
        protected abstract Task OnUpdateResourceAsync(ResourceBaseModel resource);
        #endregion

        #region Public Methods
        /// <summary>
        /// Dispose object
        /// </summary>
        public override void Dispose()
        {
            foreach (var disposable in receiver)
                disposable?.Dispose();

            base.Dispose();
        }
        #endregion
    }
}
