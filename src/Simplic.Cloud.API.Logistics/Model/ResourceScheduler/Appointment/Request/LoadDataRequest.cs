using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class LoadDataRequest : BaseModel
    {
        /// <summary>
        /// Gets or sets the appointment id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the start datetime
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end datetime
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
