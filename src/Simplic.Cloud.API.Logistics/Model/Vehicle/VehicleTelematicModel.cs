using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class VehicleTelematicModel
    {
        public string Provider { get; set; }
        public string Identifier { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
