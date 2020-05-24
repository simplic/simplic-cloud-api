using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents a notification
    /// </summary>
    public class NotificationModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the notification type name
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a list of associated appointments
        /// </summary>
        public IList<Guid> AppointmentIds { get; set; }

        /// <summary>
        /// Gets or sets the ids of the associated warnings
        /// </summary>
        public IList<Guid> WarningIds { get; set; }

        /// <summary>
        /// Gets or sets the date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the notificaiton message
        /// </summary>
        public string Message { get; set; }
    }
}
