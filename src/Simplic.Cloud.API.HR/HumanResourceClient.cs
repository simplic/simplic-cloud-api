﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// HR client. This api client contains all general and data port specific methods.
    /// </summary>
    public class HumanResourceClient : ClientBase
    {
        /// <summary>
        /// Initialize new client. 
        /// </summary>
        public HumanResourceClient()
            : base()
        {

        }

        /// <summary>
        /// Initialize client with different url. <see cref="ClientBase.DefaultUrl"/>
        /// </summary>
        /// <param name="url">Unique url</param>
        public HumanResourceClient(string url)
            : base(url)
        {

        }

        /// <summary>
        /// Initialize client and inherit the authentication
        /// </summary>
        /// <param name="client">Client instance</param>
        public HumanResourceClient(Client client)
            : base(client)
        {

        }
    }
}
