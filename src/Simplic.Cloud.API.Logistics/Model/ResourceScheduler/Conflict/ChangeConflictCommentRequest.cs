using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Request conflict change
    /// </summary>
    public class ChangeConflictCommentRequest
    {
        /// <summary>
        /// Gets or sets the id of the conflict
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the conflict comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        public string UserName { get; set; }
    }
}
