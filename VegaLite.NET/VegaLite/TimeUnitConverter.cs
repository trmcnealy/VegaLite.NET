using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class TimeUnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimeUnit) || t == typeof(TimeUnit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "date":
                    return TimeUnit.Date;
                case "day":
                    return TimeUnit.Day;
                case "hours":
                    return TimeUnit.Hours;
                case "hoursminutes":
                    return TimeUnit.Hoursminutes;
                case "hoursminutesseconds":
                    return TimeUnit.Hoursminutesseconds;
                case "milliseconds":
                    return TimeUnit.Milliseconds;
                case "minutes":
                    return TimeUnit.Minutes;
                case "minutesseconds":
                    return TimeUnit.Minutesseconds;
                case "month":
                    return TimeUnit.Month;
                case "monthdate":
                    return TimeUnit.Monthdate;
                case "monthdatehours":
                    return TimeUnit.Monthdatehours;
                case "quarter":
                    return TimeUnit.Quarter;
                case "quartermonth":
                    return TimeUnit.Quartermonth;
                case "seconds":
                    return TimeUnit.Seconds;
                case "secondsmilliseconds":
                    return TimeUnit.Secondsmilliseconds;
                case "utcdate":
                    return TimeUnit.Utcdate;
                case "utcday":
                    return TimeUnit.Utcday;
                case "utchours":
                    return TimeUnit.Utchours;
                case "utchoursminutes":
                    return TimeUnit.Utchoursminutes;
                case "utchoursminutesseconds":
                    return TimeUnit.Utchoursminutesseconds;
                case "utcmilliseconds":
                    return TimeUnit.Utcmilliseconds;
                case "utcminutes":
                    return TimeUnit.Utcminutes;
                case "utcminutesseconds":
                    return TimeUnit.Utcminutesseconds;
                case "utcmonth":
                    return TimeUnit.Utcmonth;
                case "utcmonthdate":
                    return TimeUnit.Utcmonthdate;
                case "utcmonthdatehours":
                    return TimeUnit.Utcmonthdatehours;
                case "utcquarter":
                    return TimeUnit.Utcquarter;
                case "utcquartermonth":
                    return TimeUnit.Utcquartermonth;
                case "utcseconds":
                    return TimeUnit.Utcseconds;
                case "utcsecondsmilliseconds":
                    return TimeUnit.Utcsecondsmilliseconds;
                case "utcyear":
                    return TimeUnit.Utcyear;
                case "utcyearmonth":
                    return TimeUnit.Utcyearmonth;
                case "utcyearmonthdate":
                    return TimeUnit.Utcyearmonthdate;
                case "utcyearmonthdatehours":
                    return TimeUnit.Utcyearmonthdatehours;
                case "utcyearmonthdatehoursminutes":
                    return TimeUnit.Utcyearmonthdatehoursminutes;
                case "utcyearmonthdatehoursminutesseconds":
                    return TimeUnit.Utcyearmonthdatehoursminutesseconds;
                case "utcyearquarter":
                    return TimeUnit.Utcyearquarter;
                case "utcyearquartermonth":
                    return TimeUnit.Utcyearquartermonth;
                case "year":
                    return TimeUnit.Year;
                case "yearmonth":
                    return TimeUnit.Yearmonth;
                case "yearmonthdate":
                    return TimeUnit.Yearmonthdate;
                case "yearmonthdatehours":
                    return TimeUnit.Yearmonthdatehours;
                case "yearmonthdatehoursminutes":
                    return TimeUnit.Yearmonthdatehoursminutes;
                case "yearmonthdatehoursminutesseconds":
                    return TimeUnit.Yearmonthdatehoursminutesseconds;
                case "yearquarter":
                    return TimeUnit.Yearquarter;
                case "yearquartermonth":
                    return TimeUnit.Yearquartermonth;
            }
            throw new Exception("Cannot unmarshal type TimeUnit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TimeUnit)untypedValue;
            switch (value)
            {
                case TimeUnit.Date:
                    serializer.Serialize(writer, "date");
                    return;
                case TimeUnit.Day:
                    serializer.Serialize(writer, "day");
                    return;
                case TimeUnit.Hours:
                    serializer.Serialize(writer, "hours");
                    return;
                case TimeUnit.Hoursminutes:
                    serializer.Serialize(writer, "hoursminutes");
                    return;
                case TimeUnit.Hoursminutesseconds:
                    serializer.Serialize(writer, "hoursminutesseconds");
                    return;
                case TimeUnit.Milliseconds:
                    serializer.Serialize(writer, "milliseconds");
                    return;
                case TimeUnit.Minutes:
                    serializer.Serialize(writer, "minutes");
                    return;
                case TimeUnit.Minutesseconds:
                    serializer.Serialize(writer, "minutesseconds");
                    return;
                case TimeUnit.Month:
                    serializer.Serialize(writer, "month");
                    return;
                case TimeUnit.Monthdate:
                    serializer.Serialize(writer, "monthdate");
                    return;
                case TimeUnit.Monthdatehours:
                    serializer.Serialize(writer, "monthdatehours");
                    return;
                case TimeUnit.Quarter:
                    serializer.Serialize(writer, "quarter");
                    return;
                case TimeUnit.Quartermonth:
                    serializer.Serialize(writer, "quartermonth");
                    return;
                case TimeUnit.Seconds:
                    serializer.Serialize(writer, "seconds");
                    return;
                case TimeUnit.Secondsmilliseconds:
                    serializer.Serialize(writer, "secondsmilliseconds");
                    return;
                case TimeUnit.Utcdate:
                    serializer.Serialize(writer, "utcdate");
                    return;
                case TimeUnit.Utcday:
                    serializer.Serialize(writer, "utcday");
                    return;
                case TimeUnit.Utchours:
                    serializer.Serialize(writer, "utchours");
                    return;
                case TimeUnit.Utchoursminutes:
                    serializer.Serialize(writer, "utchoursminutes");
                    return;
                case TimeUnit.Utchoursminutesseconds:
                    serializer.Serialize(writer, "utchoursminutesseconds");
                    return;
                case TimeUnit.Utcmilliseconds:
                    serializer.Serialize(writer, "utcmilliseconds");
                    return;
                case TimeUnit.Utcminutes:
                    serializer.Serialize(writer, "utcminutes");
                    return;
                case TimeUnit.Utcminutesseconds:
                    serializer.Serialize(writer, "utcminutesseconds");
                    return;
                case TimeUnit.Utcmonth:
                    serializer.Serialize(writer, "utcmonth");
                    return;
                case TimeUnit.Utcmonthdate:
                    serializer.Serialize(writer, "utcmonthdate");
                    return;
                case TimeUnit.Utcmonthdatehours:
                    serializer.Serialize(writer, "utcmonthdatehours");
                    return;
                case TimeUnit.Utcquarter:
                    serializer.Serialize(writer, "utcquarter");
                    return;
                case TimeUnit.Utcquartermonth:
                    serializer.Serialize(writer, "utcquartermonth");
                    return;
                case TimeUnit.Utcseconds:
                    serializer.Serialize(writer, "utcseconds");
                    return;
                case TimeUnit.Utcsecondsmilliseconds:
                    serializer.Serialize(writer, "utcsecondsmilliseconds");
                    return;
                case TimeUnit.Utcyear:
                    serializer.Serialize(writer, "utcyear");
                    return;
                case TimeUnit.Utcyearmonth:
                    serializer.Serialize(writer, "utcyearmonth");
                    return;
                case TimeUnit.Utcyearmonthdate:
                    serializer.Serialize(writer, "utcyearmonthdate");
                    return;
                case TimeUnit.Utcyearmonthdatehours:
                    serializer.Serialize(writer, "utcyearmonthdatehours");
                    return;
                case TimeUnit.Utcyearmonthdatehoursminutes:
                    serializer.Serialize(writer, "utcyearmonthdatehoursminutes");
                    return;
                case TimeUnit.Utcyearmonthdatehoursminutesseconds:
                    serializer.Serialize(writer, "utcyearmonthdatehoursminutesseconds");
                    return;
                case TimeUnit.Utcyearquarter:
                    serializer.Serialize(writer, "utcyearquarter");
                    return;
                case TimeUnit.Utcyearquartermonth:
                    serializer.Serialize(writer, "utcyearquartermonth");
                    return;
                case TimeUnit.Year:
                    serializer.Serialize(writer, "year");
                    return;
                case TimeUnit.Yearmonth:
                    serializer.Serialize(writer, "yearmonth");
                    return;
                case TimeUnit.Yearmonthdate:
                    serializer.Serialize(writer, "yearmonthdate");
                    return;
                case TimeUnit.Yearmonthdatehours:
                    serializer.Serialize(writer, "yearmonthdatehours");
                    return;
                case TimeUnit.Yearmonthdatehoursminutes:
                    serializer.Serialize(writer, "yearmonthdatehoursminutes");
                    return;
                case TimeUnit.Yearmonthdatehoursminutesseconds:
                    serializer.Serialize(writer, "yearmonthdatehoursminutesseconds");
                    return;
                case TimeUnit.Yearquarter:
                    serializer.Serialize(writer, "yearquarter");
                    return;
                case TimeUnit.Yearquartermonth:
                    serializer.Serialize(writer, "yearquartermonth");
                    return;
            }
            throw new Exception("Cannot marshal type TimeUnit");
        }

        public static readonly TimeUnitConverter Singleton = new TimeUnitConverter();
    }
}