﻿using Simplic.Cloud.API;
using Simplic.Cloud.API.Logistics;
using Simplic.Cloud.ResourceScheduler.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simplic.Cloud.CLI
{
    public class CLIResourceSchedulerHub : ResourceSchedulerHub
    {
        public CLIResourceSchedulerHub(ClientBase clientBase) : base(clientBase)
        {

        }

        protected override async Task OnAddDriverResourcesAsync(IList<DriverResourceModel> resources)
        {
            foreach (var resource in resources)
            {
                Console.WriteLine($"Add driver: {resource.Id}: {resource.DisplayName}");
            }
            await Task.Delay(1);
        }

        protected override async Task OnAddTractorUnitResourcesAsync(IList<TractorUnitResourceModel> resources)
        {
            foreach (var resource in resources)
            {
                Console.WriteLine($"Add tractor unit: {resource.Id}: {resource.DisplayName}");
            }
            await Task.Delay(1);
        }

        protected override async Task OnAddTrailerResourcesAsync(IList<TrailerResourceModel> resources)
        {
            foreach (var resource in resources)
            {
                Console.WriteLine($"Add trailer: {resource.Id}: {resource.DisplayName}");
            }
            await Task.Delay(1);
        }

        protected override async Task OnUpdateDriverResourceAsync(DriverResourceModel resource)
        {
            await Task.Delay(1);
        }

        protected override async Task OnUpdateTractorUnitResourceAsync(TractorUnitResourceModel resource)
        {
            await Task.Delay(1);
        }

        protected override async Task OnUpdateTrailerResourceAsync(TrailerResourceModel resource)
        {
            await Task.Delay(1);
        }

        protected override async Task OnRemoveResourceAsync(Guid resourceId)
        {
            await Task.Delay(1);
        }

        protected override Task OnAddShipmentAppointmentAsync(ShipmentAppointmentModel appointment)
        {
            throw new NotImplementedException();
        }

        protected override Task OnUpdateShipmentAppointmentAsync(ShipmentAppointmentModel appointment)
        {
            throw new NotImplementedException();
        }

        protected override Task OnAddEmptyTourAppointmentAsync(EmptyTourAppointmentModel appointment)
        {
            throw new NotImplementedException();
        }

        protected override Task OnUpdateEmptyTourAppointmentAsync(EmptyTourAppointmentModel appointment)
        {
            throw new NotImplementedException();
        }

        protected override Task OnAddDriverRestAppointmentAsync(DriverRestAppointmentModel appointment)
        {
            throw new NotImplementedException();
        }

        protected override Task OnUpdateDriverRestAppointmentAsync(DriverRestAppointmentModel appointment)
        {
            throw new NotImplementedException();
        }

        protected override Task OnRemoveAppointmentAsync(Guid appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}
