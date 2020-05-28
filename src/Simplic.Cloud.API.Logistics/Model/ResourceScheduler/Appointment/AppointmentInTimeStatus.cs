namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Gets or sets the appointment in time status
    /// </summary>
    public enum AppointmentInTimeStatus
    {
        /// <summary>
        /// The appointment is in time
        /// </summary>
        InTime = 0,

        /// <summary>
        /// The appointment is late but in tolerance
        /// </summary>
        LateInTolerance = 1,

        /// <summary>
        /// The appointment is late
        /// </summary>
        Late = 2
    }
}
