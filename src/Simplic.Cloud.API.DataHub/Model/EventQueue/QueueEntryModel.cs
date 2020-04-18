using System;

namespace Simplic.Cloud.API.DataHub
{
    /// <summary>
    /// Queue entry
    /// </summary>
    public class QueueEntryModel
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the queue entry date time
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the data id
        /// </summary>
        public Guid DataId { get; set; }

        /// <summary>
        /// Gets or sets the data type
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public string ActionType { get; set; }

        /// <summary>
        /// Gets or sets the payload
        /// </summary>
        public string Payload { get; set; }
    }
}
