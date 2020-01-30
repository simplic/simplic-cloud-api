using Simplic.Cloud.BusinessPartner.Api.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.BusinessPartner
{
    /// <summary>
    /// Contact client. This api client contains all general and data port specific methods.
    /// </summary>
    public class ContactClient : CRUDClientBase<Contact, Guid>
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public ContactClient()
            : base()
        {

        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public ContactClient(string url)
            : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public ContactClient(Client client)
            : base(client)
        {

        }

        protected override string Api => "business-partner";

        protected override string Controller => "contact";
    }
}
