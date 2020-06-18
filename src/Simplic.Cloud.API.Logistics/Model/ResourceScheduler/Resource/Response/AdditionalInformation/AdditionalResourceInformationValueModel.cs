using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents an additional resource information value. Sample implementations:
    /// 1. <see cref="AdditionalResourceInformationTextValueModel"/>
    /// 2. <see cref="AdditionalResourceInformationRangeValueModel"/>
    /// </summary>
    public class AdditionalResourceInformationValueModel
    {
        /// <summary>
        /// Gets or sets the type name
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the display type
        /// </summary>
        public string DisplayType { get; set; }
    }
}
