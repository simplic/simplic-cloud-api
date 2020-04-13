using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Appointment base class
    /// </summary>
    public class AppointmentBaseModel : BaseModel
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the appointment number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the resource ids
        /// </summary>
        public IList<Guid> Resources { get; set; }

        public DateObject Start { get; set; }
        public DateObject End { get; set; }

        public AddressModel StartAddress { get; set; }
        public AddressModel EndAddress { get; set; }
        public AddressModel CustomerAddress { get; set; }
    }
}
