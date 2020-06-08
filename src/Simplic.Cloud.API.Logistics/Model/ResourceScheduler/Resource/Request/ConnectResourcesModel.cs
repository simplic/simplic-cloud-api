using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class ConnectResourcesModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the valid from date/time
        /// </summary>
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets a list of resources
        /// </summary>
        public IList<Guid> Resources { get; set; } = new List<Guid>();
    }
}
