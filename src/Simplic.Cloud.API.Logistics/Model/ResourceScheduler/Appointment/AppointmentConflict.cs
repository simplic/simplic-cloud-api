using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class AppointmentConflict
    {
        /// <summary>
        /// Gets or sets the conflict id
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the conflict type name
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets whether the conflict was solved
        /// </summary>
        public bool Solved { get; set; }

        /// <summary>
        /// Gets or sets the conflict date
        /// </summary>
        public DateTime ConflictDate { get; set; }

        /// <summary>
        /// Gets or sets the conflict text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the conflict comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the conflict id
        /// </summary>
        public Guid Id { get; set; }
    }
}
