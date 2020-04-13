﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class VehicleClient : CRUDClientBase<VehicleModel, Guid>
    {
        public VehicleClient()
        {
        }

        public VehicleClient(string url) : base(url)
        {
        }

        public VehicleClient(IClient clientBase) : base(clientBase)
        {
        }

        protected override string Api => "logistics";

        protected override string Controller => "vehicle";
    }
}