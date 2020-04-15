using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API
{
    public abstract class CRUDClientBase<T, I> : CRUDClientBase<T, T, I>
    {
        public CRUDClientBase()
        {
        }

        public CRUDClientBase(string url) : base(url)
        {
        }

        public CRUDClientBase(IClient clientBase) : base(clientBase)
        {
        }
    }

    public abstract class CRUDClientBase<R, T, I> : ClientBase
    {
        public CRUDClientBase()
        {
        }

        public CRUDClientBase(string url) : base(url)
        {
        }

        public CRUDClientBase(IClient clientBase) : base(clientBase)
        {
        }

        public virtual async Task<R> GetAsync(I id)
        {
            return await base.GetAsync<R>(Api, Controller, "get", new Dictionary<string, string> { { "id", id.ToString() } });
        }

        public virtual async Task<CRUDResponseModel> CreateAsync(T obj)
        {
            return await PostAsync<CRUDResponseModel, T>(Api, Controller, "create", obj);
        }

        public virtual async Task<CRUDResponseModel> UpdateAsync(T obj)
        {
            return await base.PutAsync<CRUDResponseModel, T>(Api, Controller, "update", obj);
        }

        public virtual async Task<CRUDResponseModel> DeleteAsync(I id)
        {
            return await base.DeleteAsync<CRUDResponseModel>(Api, Controller, "delete", new Dictionary<string, string> { { "id", id.ToString() } });
        }

        protected abstract string Api { get; }

        protected abstract string Controller { get; }
    }
}
