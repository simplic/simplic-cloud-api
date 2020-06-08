using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoReportModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the employee id
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the last dtco activity
        /// </summary>
        public DtcoActicityModel LastDtcoActivity { get; set; }

        /// <summary>
        /// Gets or sets the dtco activities
        /// </summary>
        public List<DtcoActicityModel> DtcoActivities { get; set; }

        /// <summary>
        /// Gest or sets the daily driving time
        /// </summary>
        public DtcoDailyDrivingTimeModel DailyDrivingTime { get; set; }

        /// <summary>
        /// Gets or sets the daly rest for driving time
        /// </summary>
        public DtcoDailyRestForDrivingTimeModel DailyRestForDrivingTime { get; set; }

        /// <summary>
        /// Gets or sets the datly rest time
        /// </summary>
        public DtcoDailyRestTimeModel DailyRestTime { get; set; }

        /// <summary>
        /// Gets or sets the daily work time
        /// </summary>
        public DtcoDailyWorkTimeModel DailyWorkTime { get; set; }

        /// <summary>
        /// Gets or sets the double week driving time
        /// </summary>
        public DtcoDoubleWeekDrivingTimeModel DoubleWeekDrivingTime { get; set; }

        /// <summary>
        /// Gets or sets the driving pause time
        /// </summary>
        public DtcoDrivingPauseTimeModel DrivingPauseTime { get; set; }

        /// <summary>
        /// Gets or sets the weekly driving time
        /// </summary>
        public DtcoWeeklyDrivingTimeModel WeeklyDrivingTime { get; set; }

        /// <summary>
        /// Gets or sets the weekly rest time
        /// </summary>
        public DtcoWeeklyRestTimeModel WeeklyRestTime { get; set; }

        /// <summary>
        /// Gets or sets the weekly work time
        /// </summary>
        public DtcoWeeklyWorkTimeModel WeeklyWorkTime { get; set; }

        /// <summary>
        /// Gets or sets the working pause time
        /// </summary>
        public DtcoWorkingPauseTimeModel WorkingPauseTime { get; set; }

    }
}
