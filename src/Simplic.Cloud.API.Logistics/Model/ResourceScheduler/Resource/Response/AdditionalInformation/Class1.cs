using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents a additional information status
    /// </summary>
    public enum AdditionalInformationStatus
    {
        /// <summary>
        /// Everything is fine
        /// </summary>
        None = 0,

        /// <summary>
        /// A warning exists
        /// </summary>
        Warning = 1,

        /// <summary>
        /// Something is critical
        /// </summary>
        Critical = 2
    }
}
