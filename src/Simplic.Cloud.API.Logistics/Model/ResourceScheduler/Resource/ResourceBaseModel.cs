using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class ResourceBaseModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the resource id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the resource id
        /// </summary>
        public Guid ResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the display name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the match code
        /// </summary>
        public string MatchCode { get; set; }

        /// <summary>
        /// Gets or sets the status text
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the default dependencies
        /// </summary>
        public IList<Guid> DefaultDependingResources { get; set; }
    }
}
