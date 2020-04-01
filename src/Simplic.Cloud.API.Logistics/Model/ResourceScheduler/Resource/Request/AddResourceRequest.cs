using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Add resource request
    /// </summary>
    public class AddResourceRequest : BaseModel
    {
        /// <summary>
        /// Gets or sets the resource id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the resource type
        /// </summary>
        public ResourceType Type { get; set; }
    }
}
