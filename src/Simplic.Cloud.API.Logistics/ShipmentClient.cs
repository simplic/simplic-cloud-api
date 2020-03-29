using Simplic.Cloud.Logistics.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class ShipmentClient : CRUDClientBase<ShipmentDocument, Guid>
    {
        public ShipmentClient()
        {
        }

        public ShipmentClient(string url) : base(url)
        {
        }

        public ShipmentClient(IClient clientBase) : base(clientBase)
        {
        }

        protected override string Api => "logistics";

        protected override string Controller => "shipment";
    }
}
