using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.DataHub
{
    public class CommitModel
    {
        /// <summary>
        /// Gets or sets the queue id to commit data in
        /// </summary>
        public Guid QueueId { get; set; }

        /// <summary>
        /// Gets or sets the queue entry ids to commit
        /// </summary>
        public IList<Guid> Ids { get; set; }
    }
}
