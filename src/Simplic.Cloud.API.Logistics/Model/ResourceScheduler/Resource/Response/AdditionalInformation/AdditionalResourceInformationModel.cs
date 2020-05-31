using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Additional resource information
    /// </summary>
    public class AdditionalResourceInformationModel
    {
        /// <summary>
        /// Gets or sets the text values
        /// </summary>
        public IList<AdditionalResourceInformationTextValueModel> TextValues { get; set; }

        /// <summary>
        /// Gets or sets the range values
        /// </summary>
        public IList<AdditionalResourceInformationRangeValueModel> RangeValues { get; set; }
    }
}
