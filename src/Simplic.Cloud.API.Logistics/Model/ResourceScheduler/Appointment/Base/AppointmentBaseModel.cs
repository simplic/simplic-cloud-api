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

        #region [Date/Time]
        public DateTime StartDate { get; set; }

        public DateTime StartPlannedDate { get; set; }

        public DateTime StartActualDate { get; set; }

        public DateObjectType StartDateType { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime EndPlannedDate { get; set; }

        public DateTime EndActualDate { get; set; }

        public DateObjectType EndDateType { get; set; }

        /// <summary>
        /// Gets or sets the appointment status
        /// </summary>
        public AppointmentStatus Status { get; set; }

        /// <summary>
        /// Gets or sets whether the appointment is in time or not
        /// </summary>
        public AppointmentInTimeStatus InTimeStatus { get; set; }
        #endregion

        public AddressModel StartAddress { get; set; }
        public AddressModel EndAddress { get; set; }
        public AddressModel CustomerAddress { get; set; }
        public IList<AppointmentConflict> Conflicts { get; set; }

        public int DurationInMinutes { get; set; }
        public int CalculatedDurationInMinutes { get; set; }
    }
}
