using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.DataHub
{
    public class QueueModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int QueueSize { get; set; }
    }
}
