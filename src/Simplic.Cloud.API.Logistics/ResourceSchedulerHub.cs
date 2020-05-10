using Microsoft.AspNetCore.SignalR.Client;
using Simplic.Cloud.API.Logistics;
using Simplic.Cloud.API.Logistics.Model;
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
        private Guid? configurationId = null;

        /// <summary>
        /// Resource hub
        /// </summary>
        /// <param name="clientBase"></param>
        public ResourceSchedulerHub(ClientBase clientBase) : base("resource-scheduler", "resource-scheduler", clientBase)
        {
            receiver.Add(Connection.On<IList<ResourceGroup>>("PushAddResourceGroupsAsync", OnAddResourceGroupsAsync));
            receiver.Add(Connection.On<AddResourcesModel>("PushAddResourcesAsync", OnAddResourcesAsync));
            receiver.Add(Connection.On<Guid>("PushRemoveResourceAsync", OnRemoveResourceAsync));
            receiver.Add(Connection.On<DriverResourceModel>("PushUpdateDriverResourceAsync", OnUpdateDriverResourceAsync));
            receiver.Add(Connection.On<TractorUnitResourceModel>("PushUpdateTractorUnitResourceAsync", OnUpdateTractorUnitResourceAsync));
            receiver.Add(Connection.On<TrailerResourceModel>("PushUpdateTrailerResourceAsync", OnUpdateTrailerResourceAsync));

            receiver.Add(Connection.On<IList<TourAppointmentModel>>("PushAddTourAppointmentAsync", OnAddTourAppointmentAsync));
            receiver.Add(Connection.On<TourAppointmentModel>("PushUpdateTourAppointmentAsync", OnUpdateTourAppointmentAsync));
            receiver.Add(Connection.On<IList<EmptyTourAppointmentModel>>("PushAddEmptyTourAppointmentAsync", OnAddEmptyTourAppointmentAsync));
            receiver.Add(Connection.On<EmptyTourAppointmentModel>("PushUpdateEmptyTourAppointmentAsync", OnUpdateEmptyTourAppointmentAsync));
            receiver.Add(Connection.On<DriverRestAppointmentModel>("PushAddDriverRestAppointmentAsync", OnAddDriverRestAppointmentAsync));
            receiver.Add(Connection.On<DriverRestAppointmentModel>("PushUpdateDriverRestAppointmentAsync", OnUpdateDriverRestAppointmentAsync));
            receiver.Add(Connection.On<Guid>("PushRemoveAppointmentAsync", OnRemoveAppointmentAsync));
            receiver.Add(Connection.On<Guid>("PushAppointmentNotFoundAsync", OnAppointmentNotFoundAsync));

            receiver.Add(Connection.On<Guid>("PushLockResourceAsync", OnLockResourceAsync));
            receiver.Add(Connection.On<Guid>("PushUnlockResourceAsync", OnUnlockResourceAsync));

            receiver.Add(Connection.On<TimelineSeparatorModel>("PushAddTimelineSeparatorAsync", OnAddTimelineSeparatorAsync));
            receiver.Add(Connection.On<Guid>("PushRemoveTimelineSeparatorAsync", OnRemoveTimelineSeparatorAsync));
        }

        #region Connection
        public override async Task ConnectionReconnected(string arg)
        {
            // Join session
            if (configurationId != null)
            {
                await JoinSessionAsync(new JoinSessionModel
                {
                    ConfigurationId = configurationId.Value
                });
            }
        }
        #endregion

        #region [Request]
        /// <summary>
        /// Reqeust resource groups
        /// </summary>
        public async Task RequestResourceGroupsAsync(GetResourceGroupsModel request)
        {
            await Connection.SendAsync(nameof(RequestResourceGroupsAsync), request);
        }

        /// <summary>
        /// Reqeust resources
        /// </summary>
        public async Task RequestResourcesAsync(GetResourceModel request)
        {
            await Connection.SendAsync(nameof(RequestResourcesAsync), request);
        }

        /// <summary>
        /// Request resource scheduler data
        /// </summary>
        /// <param name="request">Request information</param>
        public async Task RequestDataAsync(LoadDataModel request)
        {
            await Connection.SendAsync(nameof(RequestDataAsync), request);
        }

        /// <summary>
        /// Add resource request
        /// </summary>
        public async Task AddResourceAsync(AddResourceModel request)
        {
            await Connection.SendAsync(nameof(AddResourceAsync), request);
        }

        /// <summary>
        /// Schedule appointment
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task ScheduleAppointmentAsync(ScheduleAppointmentModel request)
        {
            await Connection.SendAsync(nameof(ScheduleAppointmentAsync), request);
        }

        /// <summary>
        /// Set appointment status
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task SetAppointmentStatusAsync(SetAppointmentStatusRequest request)
        {
            await Connection.SendAsync(nameof(SetAppointmentStatusAsync), request);
        }

        /// <summary>
        /// Remove appointment
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task RemoveAppointmentAsync(RemoveAppointmentModel request)
        {
            await Connection.SendAsync(nameof(RemoveAppointmentAsync), request);
        }

        /// <summary>
        /// Add timeline separator
        /// </summary>
        /// <param name="request">Request instance</param>
        public async Task AddTimelineSeparatorAsync(AddTimelineSeparatorModel request)
        {
            await Connection.SendAsync(nameof(AddTimelineSeparatorAsync), request);
        }

        /// <summary>
        /// Remove timeline separator
        /// </summary>
        /// <param name="request">Request instance</param>
        public async Task RemoveTimelineSeparatorAsync(RemoveTimelineSeparatorModel request)
        {
            await Connection.SendAsync(nameof(RemoveTimelineSeparatorAsync), request);
        }

        /// <summary>
        /// Remove resource
        /// </summary>
        /// <param name="request">Request type</param>
        /// <returns></returns>
        public async Task RemoveResourceAsync(RemoveResourceModel request)
        {
            await Connection.SendAsync(nameof(RemoveResourceAsync), request);
        }

        /// <summary>
        /// Join session
        /// </summary>
        /// <param name="request">Request object</param>
        public async Task JoinSessionAsync(JoinSessionModel request)
        {
            configurationId = request.ConfigurationId;
            await Connection.SendAsync(nameof(JoinSessionAsync), request);
        }

        /// <summary>
        /// Leave session
        /// </summary>
        /// <param name="request">Request object</param>
        public async Task LeaveSessionAsync(LeaveSessionModel request)
        {
            await Connection.SendAsync(nameof(LeaveSessionAsync), request);
        }

        /// <summary>
        /// Lock resources async
        /// </summary>
        /// <param name="request">Request instance</param>
        public async Task LockResourceAsync(LockResourceModel request)
        {
            await Connection.SendAsync(nameof(LockResourceAsync), request);
        }

        /// <summary>
        /// Unlock resources async
        /// </summary>
        /// <param name="request">Request instance</param>
        public async Task UnlockResourceAsync(UnlockResourceModel request)
        {
            await Connection.SendAsync(nameof(UnlockResourceAsync), request);
        }

        /// <summary>
        /// Set warning comment
        /// </summary>
        /// <param name="request">Request instance</param>
        public async Task SetWarningDataAsync(SetWarningDataModel request)
        {
            await Connection.SendAsync(nameof(SetWarningDataAsync), request);
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
        protected abstract Task OnAddResourcesAsync(AddResourcesModel resources);

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
        /// Pushes a tour appointment
        /// </summary>
        /// <param name="appointments">Appointment</param>
        protected abstract Task OnAddTourAppointmentAsync(IList<TourAppointmentModel> appointments);

        /// <summary>
        /// Pushes a tour appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnUpdateTourAppointmentAsync(TourAppointmentModel appointment);

        /// <summary>
        /// Pushes a empty tour appointment
        /// </summary>
        /// <param name="appointment">Appointment</param>
        protected abstract Task OnAddEmptyTourAppointmentAsync(IList<EmptyTourAppointmentModel> appointments);

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

        /// <summary>
        /// Add timeline separator
        /// </summary>
        /// <param name="model">Timeline separator id</param>
        protected abstract Task OnAddTimelineSeparatorAsync(TimelineSeparatorModel model);

        /// <summary>
        /// Remove timeline separator
        /// </summary>
        /// <param name="separatorId">Separator id</param>
        protected abstract Task OnRemoveTimelineSeparatorAsync(Guid separatorId);
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
