using Simplic.Cloud.API;
using Simplic.Cloud.API.Logistics;
using Simplic.Cloud.ResourceScheduler.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test
{
    public class CLIResourceSchedulerHub : ResourceSchedulerHub
    {
        public CLIResourceSchedulerHub(ClientBase clientBase) : base(clientBase)
        {

        }

        protected override async Task OnAddResourceGroupsAsync(IList<ResourceGroup> resourceGroups)
        {
            foreach (var group in resourceGroups)
            {
                Console.WriteLine($"Group: {group.Name}");
            }
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
            Console.WriteLine(resource.Id);
            await Task.Delay(1);
        }

        protected override async Task OnUpdateTractorUnitResourceAsync(TractorUnitResourceModel resource)
        {
            Console.WriteLine(resource.Id);
            await Task.Delay(1);
        }

        protected override async Task OnUpdateTrailerResourceAsync(TrailerResourceModel resource)
        {
            await Task.Delay(1);
        }

        protected override async Task OnRemoveResourceAsync(Guid resourceId)
        {
            Console.WriteLine("Remove resource");
            await Task.Delay(1);
        }

        protected override async Task OnAddShipmentAppointmentAsync(ShipmentAppointmentModel appointment)
        {
            
        }

        protected override async Task OnUpdateShipmentAppointmentAsync(ShipmentAppointmentModel appointment)
        {
            
        }

        protected override async Task OnAddEmptyTourAppointmentAsync(EmptyTourAppointmentModel appointment)
        {
            
        }

        protected override async Task OnUpdateEmptyTourAppointmentAsync(EmptyTourAppointmentModel appointment)
        {
            
        }

        protected override async Task OnAddDriverRestAppointmentAsync(DriverRestAppointmentModel appointment)
        {

        }

        protected override async Task OnUpdateDriverRestAppointmentAsync(DriverRestAppointmentModel appointment)
        {

        }

        protected override async Task OnRemoveAppointmentAsync(Guid appointmentId)
        {

        }

        protected override async Task OnAppointmentNotFoundAsync(Guid appointmentId)
        {

        }
    }
}
