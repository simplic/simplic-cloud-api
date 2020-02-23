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
            receiver.Add(Connection.On<IList<ResourceGroup>>("PushAddResourceGroupsAsync", OnAddResourceGroupsAsync));
            receiver.Add(Connection.On<IList<TractorUnitResourceModel>>("PushAddTractorUnitResourcesAsync", OnAddTractorUnitResourcesAsync));
            receiver.Add(Connection.On<IList<TrailerResourceModel>>("PushAddTrailerResourcesAsync", OnAddTrailerResourcesAsync));
            receiver.Add(Connection.On<Guid>("PushRemoveResourceAsync", OnRemoveResourceAsync));
            receiver.Add(Connection.On<DriverResourceModel>("PushUpdateDriverResourceAsync", OnUpdateDriverResourceAsync));
            receiver.Add(Connection.On<TractorUnitResourceModel>("PushUpdateTractorUnitResourceAsync", OnUpdateTractorUnitResourceAsync));
            receiver.Add(Connection.On<TrailerResourceModel>("PushUpdateTrailerResourceAsync", OnUpdateTrailerResourceAsync));

            receiver.Add(Connection.On<ShipmentAppointmentModel>("PushAddShipmentAppointmentAsync", OnAddShipmentAppointmentAsync));
            receiver.Add(Connection.On<ShipmentAppointmentModel>("PushUpdateShipmentAppointmentAsync", OnUpdateShipmentAppointmentAsync));
            receiver.Add(Connection.On<EmptyTourAppointmentModel>("PushAddEmptyTourAppointmentAsync", OnAddEmptyTourAppointmentAsync));
            receiver.Add(Connection.On<EmptyTourAppointmentModel>("PushUpdateEmptyTourAppointmentAsync", OnUpdateEmptyTourAppointmentAsync));
            receiver.Add(Connection.On<DriverRestAppointmentModel>("PushAddDriverRestAppointmentAsync", OnAddDriverRestAppointmentAsync));
            receiver.Add(Connection.On<DriverRestAppointmentModel>("PushUpdateDriverRestAppointmentAsync", OnUpdateDriverRestAppointmentAsync));
            receiver.Add(Connection.On<Guid>("PushRemoveAppointmentAsync", OnRemoveAppointmentAsync));
            receiver.Add(Connection.On<Guid>("PushAppointmentNotFoundAsync", OnAppointmentNotFoundAsync));

            receiver.Add(Connection.On<Guid>("PushLockResourceAsync", OnLockResourceAsync));
            receiver.Add(Connection.On<Guid>("PushUnlockResourceAsync", OnLockResourceAsync));
        }

        #region [Request]
        /// <summary>
        /// Reqeust resource groups
        /// </summary>
        public async Task RequestResourceGroupsAsync(GetResourceGroupsRequest request)
        {
            await Connection.SendAsync(nameof(RequestResourceGroupsAsync), request);
        }

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
        /// Schedule appointment
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task ScheduleAppointmentAsync(ScheduleAppointmentRequest request)
        {
            await Connection.SendAsync(nameof(ScheduleAppointmentAsync), request);
        }

        /// <summary>
        /// Remove appointment
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task RemoveAppointmentAsync(RemoveAppointmentRequest request)
        {
            await Connection.SendAsync(nameof(RemoveAppointmentAsync), request);
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

        /// <summary>
        /// Lock resources async
        /// </summary>
        /// <param name="request">Request instance</param>
        public async Task LockResourceAsync(LockResourceRequest request)
        {
            await Connection.SendAsync(nameof(LockResourceAsync), request);
        }

        /// <summary>
        /// Unlock resources async
        /// </summary>
        /// <param name="request">Request instance</param>
        public async Task UnlockResourceAsync(UnlockResourceRequest request)
        {
            await Connection.SendAsync(nameof(UnlockResourceAsync), request);
        }
        #endregion

        #region [Response]
        /// <summary>
        /// Resource groups requested
        /// </summary>
        /// <param name="resourceGroups"></param>
        /// <returns></returns>
        protected abstract Task OnAddResourceGroupsAsync(IList<ResourceGroup> resourceGroups);

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

        /// <summary>
        /// Pushes a shipment appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnAddShipmentAppointmentAsync(ShipmentAppointmentModel appointment);

        /// <summary>
        /// Pushes a shipment appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnUpdateShipmentAppointmentAsync(ShipmentAppointmentModel appointment);

        /// <summary>
        /// Pushes a empty tour appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnAddEmptyTourAppointmentAsync(EmptyTourAppointmentModel appointment);

        /// <summary>
        /// Pushes a empty tour appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnUpdateEmptyTourAppointmentAsync(EmptyTourAppointmentModel appointment);

        /// <summary>
        /// Pushes a driver rest appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnAddDriverRestAppointmentAsync(DriverRestAppointmentModel appointment);

        /// <summary>
        /// Pushes a driver rest appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnUpdateDriverRestAppointmentAsync(DriverRestAppointmentModel appointment);

        /// <summary>
        /// Push remove appointment
        /// </summary>
        /// <param name="appointmentId">Appointment id</param>
        protected abstract Task OnRemoveAppointmentAsync(Guid appointmentId);

        /// <summary>
        /// Push remove appointment
        /// </summary>
        /// <param name="appointmentId">Appointment id</param>
        protected abstract Task OnAppointmentNotFoundAsync(Guid appointmentId);

        /// <summary>
        /// On resource locked
        /// </summary>
        /// <param name="resourceId">Resource id</param>
        protected abstract Task OnLockResourceAsync(Guid resourceId);

        /// <summary>
        /// On resource unlocked
        /// </summary>
        /// <param name="resourceId">Resource id</param>
        protected abstract Task OnUnlockResourceAsync(Guid resourceId);
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
