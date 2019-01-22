using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.DataPort
{
    public class TransformationResultQueueItemResponse
    {
        public Guid TransformationQueueId { get; set; }
        public Guid OrganizationId { get; set; }
    }

    public class TransformationResultResponse
    {
        public Guid Guid { get; set; }
        public Guid OrganizationId { get; set; }
        public byte[] OriginalContent { get; set; }
        public byte[] ProcessedContent { get; set; }
        public int Status { get; set; }
        public DateTime UploadTime { get; set; }
        public DateTime ProcessedTime { get; set; }
        public Guid TransformerId { get; set; }
        public string ResultMessage { get; set; }
    }
}
