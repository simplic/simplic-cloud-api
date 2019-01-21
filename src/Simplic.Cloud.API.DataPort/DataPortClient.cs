namespace Simplic.Cloud.API.DataPort
{
    /// <summary>
    /// Data port client. This api client contains all general and data port specific methods.
    /// </summary>
    public class DataPortClient : ClientBase
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public DataPortClient()
            : base()
        {

        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public DataPortClient(string url)
            : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public DataPortClient(Client client)
            : base(client)
        {

        }
    }
}
