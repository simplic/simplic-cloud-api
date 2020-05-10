namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Appointment status
    /// </summary>
    public enum AppointmentStatus
    {
        /// <summary>
        /// The appointment has no specific state
        /// </summary>
        None = 0,

        /// <summary>
        /// The appointment is running
        /// </summary>
        Running = 1,

        /// <summary>
        /// The appointment is completed / done
        /// </summary>
        Completed = 2,

        /// <summary>
        /// The appointment was skipped, because a later shipment was activated
        /// </summary>
        Skipped = 3,
    }
}