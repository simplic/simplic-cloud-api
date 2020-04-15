using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class DriverTelematicClient : ClientBase
    {
        public DriverTelematicClient()
        {
        }

        public DriverTelematicClient(string url) : base(url)
        {
        }

        public DriverTelematicClient(IClient clientBase) : base(clientBase)
        {
        }

        public async Task<DriverTelematicResult> AddShiftAsync(AddDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, AddDriverShiftModel>(Api, Controller, "add-shift", model);
        }

        public async Task<DriverTelematicResult> RemoveShiftAsync(RemoveDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, RemoveDriverShiftModel>(Api, Controller, "remove-shift", model);
        }

        public async Task<DriverTelematicResult> StartShiftAsync(StartDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, StartDriverShiftModel>(Api, Controller, "start-shift", model);
        }

        public async Task<DriverTelematicResult> EndShiftAsync(EndDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, EndDriverShiftModel>(Api, Controller, "end-shift", model);
        }

        public async Task<DriverTelematicResult> AddRestAsync(AddDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, AddDriverRestModel>(Api, Controller, "add-rest", model);
        }

        public async Task<DriverTelematicResult> RemoveRestAsync(RemoveDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, RemoveDriverRestModel>(Api, Controller, "remove-rest", model);
        }

        public async Task<DriverTelematicResult> StartRestAsync(StartDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, StartDriverRestModel>(Api, Controller, "start-rest", model);
        }

        public async Task<DriverTelematicResult> EndRestAsync(EndDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, EndDriverRestModel>(Api, Controller, "end-rest", model);
        }

        protected string Api => "resource-scheduler";

        protected string Controller => "driver-telematic";
    }
}
