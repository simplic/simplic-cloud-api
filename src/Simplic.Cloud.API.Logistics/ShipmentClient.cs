using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class ShipmentClient : CRUDClientBase<Guid, ShipmentClient>
    {
        protected override string Api => "logistics";

        protected override string Controller => "shipment";
    }
}
