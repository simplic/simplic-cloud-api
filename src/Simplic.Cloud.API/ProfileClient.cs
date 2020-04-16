using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API
{
    public class ProfileClient : ClientBase
    {
        public ProfileClient()
        {
        }

        public ProfileClient(string url) : base(url)
        {
        }

        public ProfileClient(IClient clientBase) : base(clientBase)
        {
        }

        /// <summary>
        /// Get the current profile
        /// </summary>
        /// <returns>Profile instance</returns>
        public async Task<ProfileModel> GetProfile()
        {
            return await GetAsync<ProfileModel>(Api, Controller, "get", new Dictionary<string, string> { });
        }

        protected string Api => "account";

        protected string Controller => "profile";
    }
}
