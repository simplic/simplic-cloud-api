using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Resource scheduler configuration model
    /// </summary>
    public class ConfigurationModel
    {
        /// <summary>
        /// Gets or sets the configuration id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the resource scheduler name
        /// </summary>
        public string ConfigurationName { get; set; } = "default";

        /// <summary>
        /// Gets or sets whether the resource scheduler is active or not
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the processing unit
        /// </summary>
        public IList<DependencyConfigurationModel> ProcessingUnits { get; set; } = new List<DependencyConfigurationModel>()
        {
            new DependencyConfigurationModel { Name = "drive_time" },
            new DependencyConfigurationModel { Name = "overlapping_appointment" }
        };

        /// <summary>
        /// Gets or sets the conflict resolver
        /// </summary>
        public IList<DependencyConfigurationModel> ConflictResolver { get; set; } = new List<DependencyConfigurationModel>()
        {
            new DependencyConfigurationModel { Name = "appointment_overlap" },
            new DependencyConfigurationModel { Name = "appointment_out_of_time_frame" },
            new DependencyConfigurationModel { Name = "opening_hour" },
            new DependencyConfigurationModel { Name = "weight" }
        };

        /// <summary>
        /// Gets or sets the intermediate appointment factories
        /// </summary>
        public IList<DependencyConfigurationModel> IntermediateAppointmentFactories { get; set; } = new List<DependencyConfigurationModel>
        {
            new DependencyConfigurationModel { Name = "create_empty_tour_factory" }
        };

        /// <summary>
        /// Gets or sets all notification dependencies
        /// </summary>
        public IList<DependencyConfigurationModel> Notifications { get; set; } = new List<DependencyConfigurationModel>()
        {

        };

        /// <summary>
        /// Defines the number of days after which scheduler's appointments are readonly
        /// </summary>
        public int OperationalDays { get; set; }
    }
}
