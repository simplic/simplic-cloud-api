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
    public class DriverTelematicClient : ClientBase
    {
        public DriverTelematicClient()
        {
        }

        public DriverTelematicClient(string url) : base(url)
        {
        }

        public DriverTelematicClient(IClient clientBase) : base(clientBase)
        {
        }

        public async Task<DriverTelematicResult> UploadDtcoData(DtcoReportModel model)
        {
            return await PostAsync<DriverTelematicResult, DtcoReportModel>(Api, Controller, "upload-dtco", model);
        }

        /// <summary>
        /// Create url
        /// </summary>
        /// <param name="api">Api path</param>
        /// <param name="controller">Controller name</param>
        /// <param name="action">Action name</param>
        /// <returns>Complete url</returns>
        private string _GetUrl(string api, string controller, string action)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(Url);
            urlBuilder.Append($"/{ApiVersion}");

            if (!string.IsNullOrWhiteSpace(api))
                urlBuilder.Append($"/{api}-api");

            if (!string.IsNullOrWhiteSpace(controller))
                urlBuilder.Append($"/{controller}");

            if (!string.IsNullOrWhiteSpace(action))
                urlBuilder.Append($"/{action}");

            return urlBuilder.ToString();
        }

        public async Task<DriverTelematicResult> UploadDtcoJsonData(string json)
        {
            var statusCode = HttpStatusCode.OK;

            try
            {
                if (!string.IsNullOrWhiteSpace(User?.Token))
                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", User?.Token);

                var methodUrl = _GetUrl(Api, Controller, "upload-dtco");

                var response = await HttpClient.PostAsync(methodUrl, new StringContent(json));
                statusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    // Get json and parse
                    return await response.Content.ReadAsAsync<DriverTelematicResult>();
                }
                else
                {
                    var obj = JsonConvert.SerializeObject(json);

                    throw new ApiException($"Error in put: {obj}", Api, Controller, "upload-dtco", response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new ApiException("Unexpected error in post.", Api, Controller, "upload-dtco", statusCode, ex);
            }
        }

        public async Task<DriverTelematicResult> AddShiftAsync(AddDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, AddDriverShiftModel>(Api, Controller, "add-shift", model);
        }

        public async Task<DriverTelematicResult> RemoveShiftAsync(RemoveDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, RemoveDriverShiftModel>(Api, Controller, "remove-shift", model);
        }

        public async Task<DriverTelematicResult> StartShiftAsync(StartDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, StartDriverShiftModel>(Api, Controller, "start-shift", model);
        }

        public async Task<DriverTelematicResult> EndShiftAsync(EndDriverShiftModel model)
        {
            return await PostAsync<DriverTelematicResult, EndDriverShiftModel>(Api, Controller, "end-shift", model);
        }

        public async Task<DriverTelematicResult> AddRestAsync(AddDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, AddDriverRestModel>(Api, Controller, "add-rest", model);
        }

        public async Task<DriverTelematicResult> RemoveRestAsync(RemoveDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, RemoveDriverRestModel>(Api, Controller, "remove-rest", model);
        }

        public async Task<DriverTelematicResult> StartRestAsync(StartDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, StartDriverRestModel>(Api, Controller, "start-rest", model);
        }

        public async Task<DriverTelematicResult> EndRestAsync(EndDriverRestModel model)
        {
            return await PostAsync<DriverTelematicResult, EndDriverRestModel>(Api, Controller, "end-rest", model);
        }

        protected string Api => "resource-scheduler";

        protected string Controller => "driver-telematic";
    }
}
