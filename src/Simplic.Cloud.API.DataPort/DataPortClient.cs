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
        public DataPortClient(Client client)
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
        public async Task EnqueueFile(byte[] blob, string transformerName)
        {
            await PostMultipartAsync("", "DataPort", "transformation-queue", blob, new Dictionary<string, string>
            {
                { "transformerName", transformerName }
            });
        }

        public async Task<IList<TransformationResultResponse>> GetResultQueueItems()
        {
            Debugger.Launch();
            return await GetAsync<IList<TransformationResultResponse>>("", "DataPort", "transformation-result", null);
        }

        public void GetResult(Guid queueItemId)
        {

        }

        public void SetAsProcessed()
        {

        }
    }
}
