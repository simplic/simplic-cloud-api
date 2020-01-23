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
    public abstract class ResourceSchedulerHub : BaseHub
    {
        private readonly IList<IDisposable> receiver = new List<IDisposable>();

        /// <summary>
        /// Resource hub
        /// </summary>
        /// <param name="clientBase"></param>
        public ResourceSchedulerHub(ClientBase clientBase) : base("resource-scheduler", "resource-scheduler", clientBase)
        {
            receiver.Add(Connection.On<IList<DriverResourceModel>>("PushAddDriverResourcesAsync", OnAddDriverResourcesAsync));
            receiver.Add(Connection.On<IList<TractorUnitResourceModel>>("PushAddTractorUnitResourcesAsync", OnAddTractorUnitResourcesAsync));
            receiver.Add(Connection.On<IList<TrailerResourceModel>>("PushAddTrailerResourcesAsync", OnAddTrailerResourcesAsync));
            receiver.Add(Connection.On<Guid>("PushRemoveResourceAsync", OnRemoveResourceAsync));
            receiver.Add(Connection.On<DriverResourceModel>("PushUpdateDriverResourceAsync", OnUpdateDriverResourceAsync));
            receiver.Add(Connection.On<TractorUnitResourceModel>("PushUpdateTractorUnitResourceAsync", OnUpdateTractorUnitResourceAsync));
            receiver.Add(Connection.On<TrailerResourceModel>("PushUpdateTrailerResourceAsync", OnUpdateTrailerResourceAsync));
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

        /// <summary>
        /// Join session
        /// </summary>
        /// <param name="request">Request object</param>
        public async Task JoinSessionAsync(JoinSessionRequest request)
        {
            await Connection.SendAsync(nameof(JoinSessionAsync), request);
        }

        /// <summary>
        /// Leave session
        /// </summary>
        /// <param name="request">Request object</param>
        public async Task LeaveSessionAsync(LeaveSessionRequest request)
        {
            await Connection.SendAsync(nameof(LeaveSessionAsync), request);
        }
        #endregion

        #region [Response]
        /// <summary>
        /// Pushes a list of resources
        /// </summary>
        /// <param name="resources">Resources</param>
        protected abstract Task OnAddDriverResourcesAsync(IList<DriverResourceModel> resources);

        /// <summary>
        /// Pushes a list of resources
        /// </summary>
        /// <param name="resources">Resources</param>
        protected abstract Task OnAddTractorUnitResourcesAsync(IList<TractorUnitResourceModel> resources);

        /// <summary>
        /// Pushes a list of resources
        /// </summary>
        /// <param name="resources">Resources</param>
        protected abstract Task OnAddTrailerResourcesAsync(IList<TrailerResourceModel> resources);

        /// <summary>
        /// Push update resource
        /// </summary>
        /// <param name="resource">Resource</param>
        protected abstract Task OnUpdateDriverResourceAsync(DriverResourceModel resource);

        /// <summary>
        /// Push update resource
        /// </summary>
        /// <param name="resource">Resource</param>
        protected abstract Task OnUpdateTractorUnitResourceAsync(TractorUnitResourceModel resource);

        /// <summary>
        /// Push update resource
        /// </summary>
        /// <param name="resource">Resource</param>
        protected abstract Task OnUpdateTrailerResourceAsync(TrailerResourceModel resource);

        /// <summary>
        /// Push remove resource
        /// </summary>
        /// <param name="resourceId">Resource id</param>
        protected abstract Task OnRemoveResourceAsync(Guid resourceId);
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
