using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Lock resource request
    /// </summary>
    public class LockResourceRequest : BaseModel
    {
        /// <summary>
        /// Gets or sets the resource id
        /// </summary>
        public Guid Id { get; set; }
    }
}
