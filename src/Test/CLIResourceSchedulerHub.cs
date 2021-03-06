﻿using Simplic.Cloud.API;
using Simplic.Cloud.API.Logistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class CLIResourceSchedulerHub : ResourceSchedulerHub
    {
        private IList<ResourceBaseModel> _resources = new List<ResourceBaseModel>();

        public CLIResourceSchedulerHub(ClientBase clientBase) : base(clientBase)
        {

        }

        public override Task ConnectionClosed(Exception ex)
        {
            Console.WriteLine("Closed!!!");
            return base.ConnectionClosed(ex);
        }

        public override Task ConnectionReconnected(string arg)
        {
            Console.WriteLine("Reconnected!!!");
            return base.ConnectionReconnected(arg);
        }

        public override Task ConnectionReconnecting(Exception ex)
        {
            Console.WriteLine("Reconnecting!!");
            return base.ConnectionReconnecting(ex);
        }

        protected override async Task OnAddResourceGroupsAsync(IList<ResourceGroup> resourceGroups)
        {
            Console.WriteLine("---- ---- ----");
            foreach (var group in resourceGroups)
            {
                Console.WriteLine($"Add resource group: {group.Name}");
            }
        }

        protected override async Task OnAddResourcesAsync(AddResourcesModel resources)
        {
            Console.WriteLine("---- ---- ----");
            foreach (var resource in resources.Drivers)
            {
                _resources.Add(resource);
                Console.WriteLine($"Add driver: {GetResourceText(resource)}");

                if (resource.AdditionalInformation != null)
                {
                    Console.WriteLine("Additional information:");
                    if (resource.AdditionalInformation.TextValues != null)
                    {
                        foreach (var ai in resource.AdditionalInformation.TextValues)
                        {
                            Console.WriteLine($" {ai.Type}: {ai.Text}");
                        }
                    }

                    if (resource.AdditionalInformation.RangeValues != null)
                    {
                        foreach (var ai in resource.AdditionalInformation.RangeValues)
                        {
                            Console.WriteLine($" {ai.Type}: min {ai.Min} max {ai.Max} current {ai.Current}");
                        }
                    }
                }
            }

            Console.WriteLine("---- ---- ----");
            foreach (var resource in resources.TractorUnits)
            {
                _resources.Add(resource);
                Console.WriteLine($"Add tractor unit: {GetResourceText(resource)}");
            }

            Console.WriteLine("---- ---- ----");
            foreach (var resource in resources.TractorUnits)
            {
                _resources.Add(resource);
                Console.WriteLine($"Add trailer: {GetResourceText(resource)}");
            }
        }

        protected override async Task OnUpdateDriverResourceAsync(DriverResourceModel resource)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Update driver: {GetResourceText(resource)}");
        }

        protected override async Task OnUpdateTractorUnitResourceAsync(TractorUnitResourceModel resource)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Update tractor unit: {GetResourceText(resource)}");
        }

        protected override async Task OnUpdateTrailerResourceAsync(TrailerResourceModel resource)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Update trailer: {GetResourceText(resource)}");
        }

        public string GetResourceText(ResourceBaseModel model)
        {
            return model.MatchCode + "/" + model.DisplayName;
        }

        protected override async Task OnRemoveResourceAsync(Guid resourceId)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Remove resource: {resourceId}");
        }

        public IList<AppointmentBaseModel> Appointments { get; set; } = new List<AppointmentBaseModel>();

        protected override async Task OnAddTourAppointmentAsync(IList<TourAppointmentModel> appointments)
        {
            Console.WriteLine("---- ---- ----");
            foreach (var tour in appointments)
            {
                Appointments.Add(tour);
                Console.WriteLine($"Add shipment: {GetAppointmentText(tour)}");
            }
        }

        protected override async Task OnUpdateTourAppointmentAsync(TourAppointmentModel appointment)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Update shipment: {GetAppointmentText(appointment)}");

            var toRemove = Appointments.FirstOrDefault(x => x.Id == appointment.Id);
            Appointments.Remove(toRemove);
            Appointments.Add(appointment);
        }

        protected override async Task OnAddEmptyTourAppointmentAsync(IList<EmptyTourAppointmentModel> appointments)
        {
            Console.WriteLine("---- ---- ----");
            foreach (var tour in appointments)
            {
                Appointments.Add(tour);
                Console.WriteLine($"Add empty tour: {GetAppointmentText(tour)}");
            }
        }

        protected override async Task OnUpdateEmptyTourAppointmentAsync(EmptyTourAppointmentModel appointment)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Update empty tour: {GetAppointmentText(appointment)}");

            var toRemove = Appointments.FirstOrDefault(x => x.Id == appointment.Id);
            Appointments.Remove(toRemove);
            Appointments.Add(appointment);
        }

        protected override async Task OnAddDriverRestAppointmentAsync(IList<DriverRestAppointmentModel> appointments)
        {
            Console.WriteLine("---- ---- ----");
            foreach (var appointment in appointments)
            {
                Console.WriteLine($"Add driver rest: {GetAppointmentText(appointment)}");
            }
        }

        protected override async Task OnUpdateDriverRestAppointmentAsync(DriverRestAppointmentModel appointment)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Update driver rest: {GetAppointmentText(appointment)}");
        }


        protected override async Task OnAddDriverShiftAppointmentAsync(IList<DriverShiftAppointmentModel> appointments)
        {
            Console.WriteLine("---- ---- ----");
            foreach (var appointment in appointments)
            {
                Console.WriteLine($"Add driver shoft: {GetAppointmentText(appointment)}");
            }
        }

        protected override async Task OnUpdateDriverShiftAppointmentAsync(DriverShiftAppointmentModel appointment)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Update driver shoft: {GetAppointmentText(appointment)}");
        }

        public string GetAppointmentText(AppointmentBaseModel appointmentBaseModel)
        {
            var builder = new StringBuilder();
            if (appointmentBaseModel.StartDateType == DateObjectType.Fixed)
                builder.Append("!");

            builder.Append($"{appointmentBaseModel.StartDate.ToString(@"dd.MM.yyyy hh\:mm")}[{appointmentBaseModel.StartAddress?.City}]");

            if (appointmentBaseModel.EndDateType == DateObjectType.Fixed)
                builder.Append("!");

            builder.Append($"{appointmentBaseModel.EndDate.ToString(@"dd.MM.yyyy hh\:mm")}[{appointmentBaseModel.EndAddress?.City}]@");
            builder.Append(string.Join(";", appointmentBaseModel.Resources.Select(x => _resources.FirstOrDefault(y => y.Id == x)?.DisplayName)));
            builder.Append($"S: {appointmentBaseModel.Status}");

            return builder.ToString();
        }

        protected override async Task OnRemoveAppointmentAsync(Guid appointmentId)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Remove appointment: {appointmentId}");
        }

        protected override async Task OnAppointmentNotFoundAsync(Guid appointmentId)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Remove not existing appointment: {appointmentId}");
        }

        protected override async Task OnLockResourceAsync(Guid resourceId)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Lock resource: {resourceId}");
        }

        protected override async Task OnUnlockResourceAsync(Guid resourceId)
        {
            Console.WriteLine("---- ---- ----");
            Console.WriteLine($"Unlock resource: {resourceId}");
        }

        protected override async Task OnAddTimelineSeparatorAsync(TimelineSeparatorModel model)
        {
            Console.WriteLine($"Add timeline separator: {model.Id}: {model.Date}");
        }

        protected override async Task OnRemoveTimelineSeparatorAsync(Guid separatorId)
        {
            Console.WriteLine($"Remove timeline separator: {separatorId}");
        }

        /// <summary>
        /// Pushes a list of notifications
        /// </summary>
        /// <param name="notifications">List of notifications</param>
        protected override async Task OnAddNotificationAsync(IList<NotificationModel> notifications)
        {
            foreach (var notification in notifications)
                Console.WriteLine($"NOTIFICATION: {notification.Message}");
        }
    }
}
