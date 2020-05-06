using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoActicityModel : DtcoObjectModel
    {
        /// <summary>
        /// Geta or sets the analysis timestamp
        /// </summary>
        public DateTime AnalysisTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the end timestamp
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the act type
        /// </summary>
        public int ActType { get; set; }

        /// <summary>
        /// Gets or sets the state
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// Gets or sets the card slot
        /// </summary>
        public int CardSlot { get; set; }

        /// <summary>
        /// Gets or sets the card state
        /// </summary>
        public int CardState { get; set; }

        /// <summary>
        /// Gets or sets the d8
        /// </summary>
        public bool D8 { get; set; }

        /// <summary>
        /// Gets or sets the specific condition
        /// </summary>
        public string SpecificCondition { get; set; }
    }
}
