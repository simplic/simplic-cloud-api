using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class WeightNoteModel
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public WeighingModel FirstWeighing { get; set; }
        public WeighingModel SecondWeighing { get; set; }
    }
}
