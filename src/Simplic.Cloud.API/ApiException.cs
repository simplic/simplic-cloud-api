using System;
using System.Net;

namespace Simplic.Cloud.API
{
    public class ApiException : Exception
    {
        public ApiException()
        {
        }

        public ApiException(string message) : base(message)
        {
        }

        public ApiException(string message, string api, string controller, string action, HttpStatusCode errorCode)
            : base($"{message} url: {api}/{controller}/{action}. Error code: {errorCode}")
        {

        }

        public ApiException(string message, string api, string controller, string action, HttpStatusCode errorCode, Exception innerException)
            : base($"{message} url: {api}/{controller}/{action}. Error code: {errorCode}", innerException)
        {

        }
    }
}
