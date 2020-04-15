using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class VehicleTelematicClient : ClientBase
    {
        public VehicleTelematicClient()
        {
        }

        public VehicleTelematicClient(string url) : base(url)
        {
        }

        public VehicleTelematicClient(IClient clientBase) : base(clientBase)
        {
        }

        public async Task<VehicleTelematicResult> SetLocationAsync(SetVehicleLocationModel model)
        {
            return await PostAsync<VehicleTelematicResult, SetVehicleLocationModel>(Api, Controller, "set-location", model);
        }

        public async Task<VehicleTelematicResult> SetStatusAsync(SetVehicleStatusModel model)
        {
            return await PostAsync<VehicleTelematicResult, SetVehicleStatusModel>(Api, Controller, "set-status", model);
        }

        protected string Api => "resource-scheduler";

        protected string Controller => "vehicle-telematic";
    }
}
