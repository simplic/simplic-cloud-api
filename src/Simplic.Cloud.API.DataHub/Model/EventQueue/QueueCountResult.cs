using System;

namespace Simplic.Cloud.API.DataHub.Model
{
    /// <summary>
    /// Queue count result
    /// </summary>
    public class QueueCountResult
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the queue count
        /// </summary>
        public int Count { get; set; }
    }
}
