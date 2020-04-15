﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Vehicle status request
    /// </summary>
    public class SetVehicleLocationModel : VehicleBaseModel
    {
        /// <summary>
        /// Gets or sets the vehicle location
        /// </summary>
        public VehicleLocationModel Location { get; set; }
    }
}