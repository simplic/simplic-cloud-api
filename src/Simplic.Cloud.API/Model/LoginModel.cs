using System;

namespace Simplic.Cloud.API
{
    /// <summary>
    /// Represents the login request
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Gets or sets the user mail address
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// Gets or sets the user password
        /// </summary>
        public string Password { get; set; }
    }

    /// <summary>
    /// Represents the login result
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the json web token (jwt ~user session)
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the mail address
        /// </summary>
        public string Email { get; set; }
    }
}
