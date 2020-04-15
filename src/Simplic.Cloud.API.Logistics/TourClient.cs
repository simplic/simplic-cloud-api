using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class TourClient : CRUDClientBase<TourResponseModel, TourModel, Guid>
    {
        public TourClient()
        {
        }

        public TourClient(string url) : base(url)
        {
        }

        public TourClient(IClient clientBase) : base(clientBase)
        {
        }

        protected override string Api => "logistics";

        protected override string Controller => "tour";
    }
}
