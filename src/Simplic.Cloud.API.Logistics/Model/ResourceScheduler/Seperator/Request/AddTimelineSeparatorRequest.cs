using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Add timeline Separator requests
    /// </summary>
    public class AddTimelineSeparatorRequest : BaseModel
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the start date time
        /// </summary>
        public DateTime Date { get; set; }
    }
}
