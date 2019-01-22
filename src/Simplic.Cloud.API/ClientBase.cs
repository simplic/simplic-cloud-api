using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API
{
    /// <summary>
    /// Client base
    /// </summary>
    public abstract class ClientBase : IDisposable
    {
        public const string DefaultUrl = "https://dataport.simplic.io/api";

        /// <summary>
        /// Initialize client base
        /// </summary>
        public ClientBase()
        {
            HttpClient = new HttpClient();
        }

        /// <summary>
        /// Initialize client base with custom url
        /// </summary>
        /// <param name="url">Base url</param>
        public ClientBase(string url)
            : this()
        {
            HttpClient = new HttpClient();
            this.Url = url;
        }

        /// <summary>
        /// Initialize new client base and copy important information
        /// </summary>
        /// <param name="clientBase">Client base instance</param>
        /// <exception cref="ArgumentNullException">Null check for <see cref="ClientBase"/> argument.</exception>
        public ClientBase(ClientBase clientBase)
        {
            if (clientBase == null) throw new ArgumentNullException(nameof(clientBase));

            HttpClient = new HttpClient();
            JWT = clientBase.JWT;
            Url = clientBase.Url;
        }

        /// <summary>
        /// Dispose object
        /// </summary>
        public void Dispose()
        {
            HttpClient.Dispose();
        }

        /// <summary>
        /// Create url
        /// </summary>
        /// <param name="api">Api path</param>
        /// <param name="controller">Controller name</param>
        /// <param name="action">Action name</param>
        /// <returns>Complete url</returns>
        private string GetUrl(string api, string controller, string action)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(Url);

            if (!string.IsNullOrWhiteSpace(api))
                urlBuilder.Append($"/{api}");

            if (!string.IsNullOrWhiteSpace(controller))
                urlBuilder.Append($"/{controller}");

            if (!string.IsNullOrWhiteSpace(action))
                urlBuilder.Append($"/{action}");

            return urlBuilder.ToString();
        }

        /// <summary>
        /// Post async
        /// </summary>
        /// <typeparam name="R">Return type</typeparam>
        /// <typeparam name="I">Model type</typeparam>
        /// <param name="api">Api path</param>
        /// <param name="controller">Controller</param>
        /// <param name="action">Action</param>
        /// <param name="model">Model to post</param>
        /// <returns>Return model</returns>
        protected async Task<R> PostAsync<R, I>(string api, string controller, string action, I model)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(JWT))
                {
                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", JWT);
                }

                var methodUrl = GetUrl(api, controller, action);

                var response = await HttpClient.PostAsJsonAsync<I>(methodUrl, model);

                if (response.IsSuccessStatusCode)
                {
                    // Get json and parse
                    return await response.Content.ReadAsAsync<R>();
                }
                else
                {
                    throw new ApiException("Error in post.", api, controller, action, response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new ApiException("Unexpected error in post.", api, controller, action, System.Net.HttpStatusCode.ServiceUnavailable, ex);
            }
        }

        /// <summary>
        /// Post async
        /// </summary>
        /// <typeparam name="R">Return type</typeparam>
        /// <typeparam name="I">Model type</typeparam>
        /// <param name="api">Api path</param>
        /// <param name="controller">Controller</param>
        /// <param name="action">Action</param>
        /// <param name="model">Model to post</param>
        /// <returns>Return model</returns>
        protected async Task<T> GetAsync<T>(string api, string controller, string action, IDictionary<string, string> parameter)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(JWT))
                {
                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", JWT);
                }

                var methodUrl = GetUrl(api, controller, action);
                if (parameter != null)
                {
                    // TODO: Add to URL
                }

                var response = await HttpClient.GetAsync(methodUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Get json and parse
                    return await response.Content.ReadAsAsync<T>();
                }
                else
                {
                    throw new ApiException("Error in get.", api, controller, action, response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new ApiException("Unexpected error in get.", api, controller, action, System.Net.HttpStatusCode.ServiceUnavailable, ex);
            }
        }

        protected async Task PostMultipartAsync(string api, string controller, string action, byte[] blob, IDictionary<string, string> formData)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(JWT))
                {
                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", JWT);
                }

                var methodUrl = GetUrl(api, controller, action);

                var requestContent = new MultipartFormDataContent();
                var fileContent = new ByteArrayContent(blob);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                requestContent.Add(fileContent, "FileInJsonFormat", "file");

                if (formData != null)
                {
                    Debugger.Launch();
                    foreach (var data in formData)
                    {
                        var content = new StringContent(data.Value, Encoding.UTF8, "application/json");
                        requestContent.Add(content, data.Key);
                    }
                }

                var response = await HttpClient.PostAsync(methodUrl, requestContent);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApiException($"Error in multipart post: {responseBody}", api, controller, action, response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new ApiException("Unexpected error in multipart post.", api, controller, action, HttpStatusCode.ServiceUnavailable, ex);
            }
        }

        /// <summary>
        /// Gets the http client instance
        /// </summary>
        protected HttpClient HttpClient { get; }

        /// <summary>
        /// Gets or sets the current jwt. Get is protected for security reason. However, the getter can be accesses by
        /// using reflection.
        /// </summary>
        public string JWT { protected get; set; }

        /// <summary>
        /// Gets the client url
        /// </summary>
        public string Url { get; protected set; } = DefaultUrl;
    }
}
