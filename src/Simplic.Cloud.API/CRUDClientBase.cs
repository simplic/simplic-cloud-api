using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API
{
    public abstract class CRUDClientBase<T, I> : ClientBase
    {
        public CRUDClientBase()
        {
        }

        public CRUDClientBase(string url) : base(url)
        {
        }

        public CRUDClientBase(ClientBase clientBase) : base(clientBase)
        {
        }

        public virtual async Task<T> GetAsync<I>(I id)
        {
            Debugger.Launch();
            return await base.GetAsync<T>(Api, Controller, "get", new Dictionary<string, string> { { "id", id.ToString() } });
        }

        public virtual async Task<T> CreateAsync(T obj)
        {
            return await PostAsync<T, T>(Api, Controller, "create", obj);
        }

        public virtual async Task<T> UpdateAsync(T obj)
        {
            return await base.PutAsync<T, T>(Api, Controller, "update", obj);
        }

        public virtual async Task<T> DeleteAsync<I>(I id)
        {
            return await base.DeleteAsync<T>(Api, Controller, "delete", new Dictionary<string, string> { { "id", id.ToString() } });
        }

        protected abstract string Api { get; }

        protected abstract string Controller { get; }
    }
}
