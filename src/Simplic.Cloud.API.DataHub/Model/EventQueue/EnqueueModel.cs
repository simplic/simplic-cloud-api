using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.DataHub
{
    /// <summary>
    /// Enqueue model
    /// </summary>
    public class EnqueueModel
    {
        /// <summary>
        /// Gets or sets the data id
        /// </summary>
        public Guid DataId { get; set; }

        /// <summary>
        /// Gets or sets the payload
        /// </summary>
        public string Payload { get; set; }

        /// <summary>
        /// Gets or sets the data type
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public string ActionType { get; set; }
    }
}
