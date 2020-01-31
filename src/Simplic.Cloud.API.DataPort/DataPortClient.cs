using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

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
        public DataPortClient(IClient client)
            : base(client)
        {

        }

        /// <summary>
        /// Enqueue file for processing in data port web api
        /// </summary>
        /// <param name="blob">Blob to enqueue</param>
        /// <param name="transformerName"></param>
        /// <returns></returns>
        /// <exception cref="ApiException">If posting the multipart content is fails</exception>
        public async Task EnqueueFile(byte[] blob, string transformerName, string fileName)
        {
            await PostMultipartAsync("", "DataPort", "transformation-queue", blob, new Dictionary<string, string>
            {
                { "transformerName", transformerName },
                { "fileName", fileName }
            });
        }

        /// <summary>
        /// Get pending result queue items
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ApiException">Get request failed</exception>
        public async Task<IList<TransformationResultQueueItemResponse>> GetResultQueueItems()
        {
            return await GetAsync<IList<TransformationResultQueueItemResponse>>("", "DataPort", "transformation-result", null);
        }

        /// <summary>
        /// Get data port result
        /// </summary>
        /// <param name="queueItemId">Unique queue item</param>
        /// <returns>Result instance</returns>
        public async Task<TransformationResultResponse> GetResult(Guid queueItemId)
        {
            return await GetAsync<TransformationResultResponse>("", "DataPort", $"transformation-queue/{queueItemId}", null);
        }

        /// <summary>
        /// Remove result queue item
        /// </summary>
        /// <param name="queueItemId">Unique queue item id</param>
        /// <returns>Async result</returns>
        public async Task RemoveResultQueueItem(Guid queueItemId)
        {
            await DeleteAsync<string>("", "DataPort", $"transformation-result/{queueItemId}", null);
        }
    }
}
