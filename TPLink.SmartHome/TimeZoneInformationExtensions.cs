using System;
using System.Text.RegularExpressions;

namespace TPLink.SmartHome
{
	internal static class TimeZoneInformationExtensions
    {
        private readonly static Regex tzRegex = new Regex(@"^(?<StandardName>[A-Z]{3,})(?<OffsetHour>[+-]?\d{1,2})(?::(?<OffsetMinute>\d{2}(?::(?<OffsetSecond>\d{2}))?))?(?<DaylightName>[A-Z]{3,})(?:,)(?:M)(?<StartMonth>\d{1,2})(?:.)(?<StartWeek>\d)(?:.)(?<StartDay>\d)(?:/(?<StartHour>\d{1,2})(?::(?<StartMinute>\d{2}(?::(?<StartSecond>\d{2}))?))?)?(?:,)(?:M)(?<EndMonth>\d{1,2})(?:.)(?<EndWeek>\d)(?:.)(?<EndDay>\d)(?:/(?<EndHour>\d{1,2})(?::(?<EndMinute>\d{2}(?::(?<EndSecond>\d{2}))?))?)?$", RegexOptions.Compiled);

        public static TimeZoneInfo FromPOSIXString(string tz)
        {
            return TimeZoneInfo.Local;
            //Match match = tzRegex.Match(tz);
            //if (!match.Success)
            //{
            //    throw new FormatException(string.Format("The string '{0}' could not be parsed as a valid POSIX timezone.", tz));
            //}

            //TimeSpan offset = new TimeSpan(
            //    match.Groups["OffsetHour"].Success ? int.Parse(match.Groups["OffsetHour"].Value) : 0,
            //    match.Groups["OffsetMinute"].Success ? int.Parse(match.Groups["OffsetMinute"].Value) : 0,
            //    match.Groups["OffsetSecond"].Success ? int.Parse(match.Groups["OffsetSecond"].Value) : 0);

            //TimeZoneInfo.TransitionTime startTransition = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(
            //    new DateTime(1, 1, 1,
            //        match.Groups["StartHour"].Success ? int.Parse(match.Groups["StartHour"].Value) : 2,
            //        match.Groups["StartMinute"].Success ? int.Parse(match.Groups["StartMinute"].Value) : 0,
            //        match.Groups["StartSecond"].Success ? int.Parse(match.Groups["StartSecond"].Value) : 0),
            //    int.Parse(match.Groups["StartMonth"].Value),
            //    int.Parse(match.Groups["StartWeek"].Value),
            //    (DayOfWeek)int.Parse(match.Groups["StartDay"].Value));

            //TimeZoneInfo.TransitionTime endTransition = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(
            //    new DateTime(1, 1, 1,
            //        match.Groups["EndHour"].Success ? int.Parse(match.Groups["EndHour"].Value) : 2,
            //        match.Groups["EndMinute"].Success ? int.Parse(match.Groups["EndMinute"].Value) : 0,
            //        match.Groups["EndSecond"].Success ? int.Parse(match.Groups["EndSecond"].Value) : 0),
            //    int.Parse(match.Groups["EndMonth"].Value),
            //    int.Parse(match.Groups["EndWeek"].Value),
            //    (DayOfWeek)int.Parse(match.Groups["EndDay"].Value));

            //TimeZoneInfo.AdjustmentRule[] adjustments = {
            //    TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(
            //        new DateTime(1999, 10, 1),
            //        DateTime.MaxValue.Date,
            //        TimeSpan.FromHours(1),
            //        startTransition,
            //        endTransition)
            // };

            //return TimeZoneInfo.CreateCustomTimeZone(tz, -offset,
            //    match.Groups["StandardName"].Value + " / " + match.Groups["DaylightName"].Value,
            //    match.Groups["StandardName"].Value,
            //    match.Groups["DaylightName"].Value,
            //    adjustments);
        }
    }
}
