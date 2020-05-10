using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics.Model
{
    public class AggregatedPriceModel
    {
        public double SalesPrice { get; set; }
        public double PurchasePrice { get; set; }
        public double Margin { get; set; }
        public double Toll { get; set; }
        public double Fuel { get; set; }
    }
}
