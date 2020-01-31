namespace Simplic.Cloud.API
{
    public interface IClient
    {
        /// <summary>
        /// Gets or sets the current jwt. Get is protected for security reason. However, the getter can be accesses by
        /// using reflection.
        /// </summary>
        User User { get; set; }

        /// <summary>
        /// Gets the client url
        /// </summary>
        string Url { get; }
    }
}
