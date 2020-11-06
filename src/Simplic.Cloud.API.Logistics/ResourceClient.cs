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
    public class ResourceClient : ClientBase
    {
        public ResourceClient()
        {
        }

        public ResourceClient(string url) : base(url)
        {
        }

        public ResourceClient(IClient clientBase) : base(clientBase)
        {
        }

        public virtual async Task<IList<AdditionalInformationTypeModel>> GetAdditionalInformationTypesAsync()
        {
            return await base.GetAsync<IList<AdditionalInformationTypeModel>>(Api, Controller, "get-additional-information-types", new Dictionary<string, string> { });
        }

        public virtual async Task<object> ConnectResourcesAsync(ConnectResourcesModel model)
        {
            return await PostAsync<object, ConnectResourcesModel>(Api, Controller, "connect-resources", model);
        }

        public virtual async Task<object> ConnectResourcesAsync(RequestConnectedResourcesModel model)
        {
            return await PostAsync<object, ConnectedResourcesResponseModel>(Api, Controller, "connect-resources", model);
        }

        protected string Api => "resource-scheduler";

        protected string Controller => "resource";
    }
}
