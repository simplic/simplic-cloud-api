using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class ShiftClient : CRUDClientBase<ShiftResponseModel, ShiftModel, Guid>
    {
        public ShiftClient()
        {
        }

        public ShiftClient(string url) : base(url)
        {
        }

        public ShiftClient(IClient clientBase) : base(clientBase)
        {
        }

        protected override string Api => "logistics";

        protected override string Controller => "shift";
    }
}
