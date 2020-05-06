using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoWeeklyRestTimeModel : DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the analysis timestamp
        /// </summary>
        public DateTime AnalysisTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the last normal rest end date
        /// </summary>
        public DateTime LastNormalRestEndDate { get; set; }

        /// <summary>
        /// Gets or sets the next rest start date
        /// </summary>
        public DateTime NextRestStartDate { get; set; }

        /// <summary>
        /// Gets or sets the week rest acticity info
        /// </summary>
        public List<DtcoWeekRestActivityInfoModel> WeekRestActivityInfo { get; set; }

        /// <summary>
        /// Gets or sets the detected reduced weekly rests to compensate
        /// </summary>
        public List<DtcoDetectedReducedWeeklyRestsToCompensateModel> DetectedReducedWeeklyRestsToCompensate { get; set; }

        /// <summary>
        /// Gets or sets the duration of last weekly rest
        /// </summary>
        public DtcoDateModel DurationOfLastWeeklyRest { get; set; }

        /// <summary>
        ///  Gets or sets the minimum duration of the next rest
        /// </summary>
        public DtcoDateModel MinDurationOfNextRest { get; set; }

        /// <summary>
        /// Gets or sets the current rest duration
        /// </summary>
        public DtcoDateModel CurrentRestDuration { get; set; }

        /// <summary>
        /// Gets or sets the current duration
        /// </summary>
        public DtcoDateModel CurrentDuration { get; set; }

        /// <summary>
        /// Gets or sets the remaining duration
        /// </summary>
        public DtcoDateModel RemainingDuration { get; set; }

        /// <summary>
        /// Gets or sets the max allowed duration
        /// </summary>
        public DtcoDateModel MaxAllowedDuration { get; set; }
    }
}
