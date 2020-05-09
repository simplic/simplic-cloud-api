using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class DateRangeModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateRangeType Type { get; set; }
    }
}
