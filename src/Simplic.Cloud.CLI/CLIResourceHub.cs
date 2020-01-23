using Simplic.Cloud.API;
using Simplic.Cloud.API.Logistics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simplic.Cloud.CLI
{
    public class CLIResourceHub : ResourceHub
    {
        public CLIResourceHub(ClientBase clientBase) : base(clientBase)
        {

        }

        protected override async Task OnAddResourceAsync(Cloud.ResourceScheduler.Api.Model.ResourceBaseModel resource)
        {
            await Task.Delay(1);
        }

        protected override async Task OnAddResourcesAsync(IList<Cloud.ResourceScheduler.Api.Model.ResourceBaseModel> resources)
        {
            foreach (var resource in resources)
            {
                Console.WriteLine($"Id: {resource.Id}: {resource.DisplayName}");
            }

            await Task.Delay(1);
        }

        protected override async Task OnRemoveResourceAsync(Guid resourceId)
        {
            await Task.Delay(1);
        }

        protected override async Task OnUpdateResourceAsync(Cloud.ResourceScheduler.Api.Model.ResourceBaseModel resource)
        {
            await Task.Delay(1);
        }
    }
}
