namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Shift activity status
    /// </summary>
    public enum ShiftActivityStatus
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
        Completed = 2
    }
}