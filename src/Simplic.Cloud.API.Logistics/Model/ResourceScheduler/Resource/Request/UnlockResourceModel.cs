using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Unlock resource request
    /// </summary>
    public class UnlockResourceModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the resource id
        /// </summary>
        public Guid Id { get; set; }
    }
}
