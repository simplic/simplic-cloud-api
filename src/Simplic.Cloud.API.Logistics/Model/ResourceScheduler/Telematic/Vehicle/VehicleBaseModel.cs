using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents the basic vehicle API model
    /// </summary>
    public abstract class VehicleBaseModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the vehicle id
        /// </summary>
        public Guid Id { get; set; }
    }
}
