using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class NotificationClient : ClientBase
    {
        public NotificationClient()
        {
        }

        public NotificationClient(string url) : base(url)
        {
        }

        public NotificationClient(IClient clientBase) : base(clientBase)
        {
        }

        public virtual async Task<IList<NotificationTypeModel>> GetTypesAsync()
        {
            return await base.GetAsync<IList<NotificationTypeModel>>(Api, Controller, "get-types", new Dictionary<string, string> { });
        }

        protected string Api => "resource-scheduler";

        protected string Controller => "notification";
    }
}
