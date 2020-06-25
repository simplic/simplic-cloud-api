namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents the current driver status
    /// </summary>
    public enum DriverStatus
    {
        /// <summary>
        /// Unknown status
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Driver is making a rest
        /// </summary>
        Rest = 1,

        /// <summary>
        /// Driver is driving
        /// </summary>
        Drive = 2,

        /// <summary>
        /// Driver is working
        /// </summary>
        Work = 3,

        /// <summary>
        /// Gets or sets the ready for work state
        /// </summary>
        ReadyForWork = 4
    }
}