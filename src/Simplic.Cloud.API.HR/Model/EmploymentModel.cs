using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.HR.Document
{
    public class EmploymentModel
    {
        /// <summary>
        /// Gets or sets the employment number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets whether the employment is active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the telematic systems
        /// </summary>
        public IList<TelematicSystemDocument> TelematicSystems { get; set; } = new List<TelematicSystemDocument>();
    }
}
