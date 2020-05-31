using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Additional value as range
    /// </summary>
    public class AdditionalResourceInformationRangeValueModel : AdditionalResourceInformationValueModel
    {
        /// <summary>
        /// Gets or sets the minimal value
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// Gets or sets the maximal value
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// Gets or sets the current value
        /// </summary>
        public double Current { get; set; }
    }
}
