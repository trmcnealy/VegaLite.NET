namespace VegaLite
{
    /// <summary>
    /// Time unit for the field to be filtered.
    ///
    /// Time unit (e.g., `year`, `yearmonth`, `month`, `hours`) for a temporal field.
    /// or [a temporal field that gets casted as
    /// ordinal](https://vega.github.io/vega-lite/docs/type.html#cast).
    ///
    /// __Default value:__ `undefined` (None)
    ///
    /// __See also:__ [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html)
    /// documentation.
    ///
    /// The timeUnit.
    /// </summary>
    public enum TimeUnit { Date, Day, Hours, Hoursminutes, Hoursminutesseconds, Milliseconds, Minutes, Minutesseconds, Month, Monthdate, Monthdatehours, Quarter, Quartermonth, Seconds, Secondsmilliseconds, Utcdate, Utcday, Utchours, Utchoursminutes, Utchoursminutesseconds, Utcmilliseconds, Utcminutes, Utcminutesseconds, Utcmonth, Utcmonthdate, Utcmonthdatehours, Utcquarter, Utcquartermonth, Utcseconds, Utcsecondsmilliseconds, Utcyear, Utcyearmonth, Utcyearmonthdate, Utcyearmonthdatehours, Utcyearmonthdatehoursminutes, Utcyearmonthdatehoursminutesseconds, Utcyearquarter, Utcyearquartermonth, Year, Yearmonth, Yearmonthdate, Yearmonthdatehours, Yearmonthdatehoursminutes, Yearmonthdatehoursminutesseconds, Yearquarter, Yearquartermonth };
}