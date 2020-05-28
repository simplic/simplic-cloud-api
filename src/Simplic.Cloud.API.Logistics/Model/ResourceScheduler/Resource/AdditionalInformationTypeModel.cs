using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents an additional information type
    /// </summary>
    public class AdditionalInformationTypeModel
    {
        /// <summary>
        /// Gets or sets the name of the additional information
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value type
        /// </summary>
        public string ValueType { get; set; }
    }
}
