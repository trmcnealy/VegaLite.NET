using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Object for defining datetime in Vega-Lite Filter.
    /// If both month and quarter are provided, month has higher precedence.
    /// `day` cannot be combined with other date.
    /// We accept string for month and day names.
    /// </summary>
    public class DateTime
    {
        /// <summary>
        /// Integer value representing the date from 1-31.
        /// </summary>
        [JsonProperty("date",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Date { get; set; }

        /// <summary>
        /// Value representing the day of a week. This can be one of:
        /// (1) integer value -- `1` represents Monday;
        /// (2) case-insensitive day name (e.g., `"Monday"`);
        /// (3) case-insensitive, 3-character short day name (e.g., `"Mon"`).
        ///
        /// **Warning:** A DateTime definition object with `day`** should not be combined with
        /// `year`, `quarter`, `month`, or `date`.
        /// </summary>
        [JsonProperty("day",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Day? Day { get; set; }

        /// <summary>
        /// Integer value representing the hour of a day from 0-23.
        /// </summary>
        [JsonProperty("hours",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; }

        /// <summary>
        /// Integer value representing the millisecond segment of time.
        /// </summary>
        [JsonProperty("milliseconds",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Milliseconds { get; set; }

        /// <summary>
        /// Integer value representing the minute segment of time from 0-59.
        /// </summary>
        [JsonProperty("minutes",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Minutes { get; set; }

        /// <summary>
        /// One of:
        /// (1) integer value representing the month from `1`-`12`. `1` represents January;
        /// (2) case-insensitive month name (e.g., `"January"`);
        /// (3) case-insensitive, 3-character short month name (e.g., `"Jan"`).
        /// </summary>
        [JsonProperty("month",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Month? Month { get; set; }

        /// <summary>
        /// Integer value representing the quarter of the year (from 1-4).
        /// </summary>
        [JsonProperty("quarter",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Quarter { get; set; }

        /// <summary>
        /// Integer value representing the second segment (0-59) of a time value
        /// </summary>
        [JsonProperty("seconds",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Seconds { get; set; }

        /// <summary>
        /// A boolean flag indicating if date time is in utc time. If false, the date time is in
        /// local time
        /// </summary>
        [JsonProperty("utc",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Utc { get; set; }

        /// <summary>
        /// Integer value representing the year.
        /// </summary>
        [JsonProperty("year",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Year { get; set; }
    }
}
