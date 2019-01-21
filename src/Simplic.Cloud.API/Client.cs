using System.Threading.Tasks;

namespace Simplic.Cloud.API
{
    /// <summary>
    /// Cloud api client. Login should be done before calling any other endpoint.
    /// </summary>
    public class Client : ClientBase
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public Client()
        {
            
        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public Client(string url) : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public Client(Client client) 
            : base(client)
        {
            
        }

        /// <summary>
        /// Login into the a user account. The session will be stored in the current client instance.
        /// </summary>
        /// <param name="email">User account mail address</param>
        /// <param name="password">User account password</param>
        /// <returns>Instance of <see cref="LoginResult"/> if login was successful</returns>
        /// <exception cref="ApiException">If the login process fails</exception>
        public async Task<LoginResult> LoginAsync(string email, string password)
        {
            var result = await PostAsync<LoginResult, LoginRequest>("", "user", "login", new LoginRequest
            {
                EMail = email,
                Password = password
            });

            JWT = result.JWT;

            return result;
        }
    }
}
