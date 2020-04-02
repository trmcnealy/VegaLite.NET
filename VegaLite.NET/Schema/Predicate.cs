using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class Predicate
    {
        [JsonProperty("not",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Not { get; set; }

        [JsonProperty("and",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<LogicalOperandPredicate> And { get; set; }

        [JsonProperty("or",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<LogicalOperandPredicate> Or { get; set; }

        /// <summary>
        /// The value that the field should be equal to.
        /// </summary>
        [JsonProperty("equal",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Equal? Equal { get; set; }

        /// <summary>
        /// Field to be filtered.
        /// </summary>
        [JsonProperty("field",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// Time unit for the field to be filtered.
        /// </summary>
        [JsonProperty("timeUnit",
                      NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnit? TimeUnit { get; set; }

        /// <summary>
        /// An array of inclusive minimum and maximum values
        /// for a field value of a data item to be included in the filtered data.
        /// </summary>
        [JsonProperty("range",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<PurpleRange> Range { get; set; }

        /// <summary>
        /// A set of values that the `field`'s value should be a member of,
        /// for a data item included in the filtered data.
        /// </summary>
        [JsonProperty("oneOf",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<Equal> OneOf { get; set; }

        /// <summary>
        /// The value that the field should be less than.
        /// </summary>
        [JsonProperty("lt",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Lt { get; set; }

        /// <summary>
        /// The value that the field should be greater than.
        /// </summary>
        [JsonProperty("gt",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Gt { get; set; }

        /// <summary>
        /// The value that the field should be less than or equals to.
        /// </summary>
        [JsonProperty("lte",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Lte { get; set; }

        /// <summary>
        /// The value that the field should be greater than or equals to.
        /// </summary>
        [JsonProperty("gte",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Gte { get; set; }

        /// <summary>
        /// If set to true the field's value has to be valid, meaning both not `null` and not
        /// [`NaN`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/NaN).
        /// </summary>
        [JsonProperty("valid",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Valid { get; set; }

        /// <summary>
        /// Filter using a selection name.
        /// </summary>
        [JsonProperty("selection",
                      NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }
}
