﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.DataPort
{
    public class TransformationResultResponse
    {
        public Guid TransformationQueueId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
