﻿using System.Collections.Generic;
using DateObject = System.DateTime;

using Microsoft.Recognizers.Text.Number;
using System;

namespace Microsoft.Recognizers.Text.DateTime
{
    public class BaseDateTimeAltParser : IDateTimeParser
    {
        public static readonly string ParserName = Constants.SYS_DATETIME_DATETIMEALT; // "DateTimeALT";

        private readonly IDateTimeAltParserConfiguration config;

        public BaseDateTimeAltParser(IDateTimeAltParserConfiguration configuration)
        {
            config = configuration;
        }

        public ParseResult Parse(ExtractResult result)
        {
            return this.Parse(result, DateObject.Now);
        }

        public DateTimeParseResult Parse(ExtractResult er, DateObject refTime)
        {
            var referenceTime = refTime;

            object value = null;
            if (er.Type.Equals(ParserName))
            {
                var innerResult = ParseDateTimeAndTimeAlt(er, referenceTime);

                if (innerResult.Success)
                {
                    value = innerResult;
                }
            }

            var ret = new DateTimeParseResult
            {
                Text = er.Text,
                Start = er.Start,
                Length = er.Length,
                Type = er.Type,
                Data = er.Data,
                Value = value,
                TimexStr = value == null ? "" : ((DateTimeResolutionResult)value).Timex,
                ResolutionStr = ""
            };

            return ret;
        }

        // merge the entity with its related contexts and then parse the combine text
        private DateTimeResolutionResult ParseDateTimeAndTimeAlt(ExtractResult er, DateObject referenceTime)
        {
            var ret = new DateTimeResolutionResult();

            // original type of the extracted entity
            var subType = ((Dictionary<string, object>)(er.Data))[Constants.SubType].ToString();
            var dateTimeEr = new ExtractResult();

            // e.g. {next week Mon} or {Tue}, formmer--"next week Mon" doesn't contain "context" key
            var hasContext = false;
            ExtractResult contextEr = null;
            if (((Dictionary<string, object>)er.Data).ContainsKey(Constants.Context))
            {
                contextEr = (ExtractResult)((Dictionary<string, object>)er.Data)[Constants.Context];
                dateTimeEr.Text = $"{contextEr.Text} {er.Text}";
                hasContext = true;
            }
            else
            {
                dateTimeEr.Text = er.Text;
            }
            var dateTimePr = new DateTimeParseResult();

            if (subType == Constants.SYS_DATETIME_DATE)
            {
                dateTimeEr.Type = Constants.SYS_DATETIME_DATE;
                dateTimePr = this.config.DateParser.Parse(dateTimeEr, referenceTime);
            }
            else if (subType == Constants.SYS_DATETIME_TIME)
            {
                if (!hasContext)
                {
                    dateTimeEr.Type = Constants.SYS_DATETIME_TIME;
                    dateTimePr = this.config.TimeParser.Parse(dateTimeEr, referenceTime);
                }
                else if (contextEr.Type == Constants.SYS_DATETIME_DATE || contextEr.Type == Constants.ContextType_RELATIVE_PREFIX)
                {
                    // for cases:
                    //      Monday 9 am or 11 am
                    //      next 9 am or 11 am
                    dateTimeEr.Type = Constants.SYS_DATETIME_DATETIME;
                    dateTimePr = this.config.DateTimeParser.Parse(dateTimeEr, referenceTime);
                }
                else if (contextEr.Type == Constants.ContextType_AM_PM)
                {
                    // for cases: in the afternoon 3 o'clock or 5 o'clock
                    dateTimeEr.Type = Constants.SYS_DATETIME_TIME;
                    dateTimePr = this.config.TimeParser.Parse(dateTimeEr, referenceTime);
                }
            }
            else if (subType == Constants.SYS_DATETIME_DATETIME)
            {
                // "next week Mon 9 am or Tue 1 pm"
                dateTimeEr.Type = Constants.SYS_DATETIME_DATETIME;
                dateTimePr = this.config.DateTimeParser.Parse(dateTimeEr, referenceTime);
            }
            else if (subType == Constants.SYS_DATETIME_TIMEPERIOD)
            {
                if (!hasContext)
                {
                    dateTimeEr.Type = Constants.SYS_DATETIME_TIMEPERIOD;
                    dateTimePr = this.config.TimePeriodParser.Parse(dateTimeEr, referenceTime);
                }
                else if (contextEr.Type == Constants.SYS_DATETIME_DATE || contextEr.Type == Constants.ContextType_RELATIVE_PREFIX)
                {
                    dateTimeEr.Type = Constants.SYS_DATETIME_DATETIMEPERIOD;
                    dateTimePr = this.config.DateTimePeriodParser.Parse(dateTimeEr, referenceTime);
                }
            }
            else if (subType == Constants.SYS_DATETIME_DATETIMEPERIOD)
            {
                if (!hasContext)
                {
                    dateTimeEr.Type = Constants.SYS_DATETIME_DATETIMEPERIOD;
                    dateTimePr = this.config.DateTimePeriodParser.Parse(dateTimeEr, referenceTime);
                }
            }

            if (dateTimePr.Value != null)
            {
                ret.FutureValue = ((DateTimeResolutionResult)dateTimePr.Value).FutureValue;
                ret.PastValue = ((DateTimeResolutionResult)dateTimePr.Value).PastValue;
                ret.Timex = dateTimePr.TimexStr;
                // create resolution
                GetResolution(er, dateTimePr, ret);
                ret.Success = true;
            }

            return ret;
        }

        private void GetResolution(ExtractResult er, DateTimeParseResult pr, DateTimeResolutionResult ret)
        {
            var parentText = (string)((Dictionary<string, object>)er.Data)[ExtendedModelResult.ParentTextKey];
            var type = pr.Type;
            var isPeriod = false;
            var isSinglePoint = false;
            string singlePointResolution = "";
            string pastStartPointResolution = "";
            string pastEndPointResolution = "";
            string futureStartPointResolution = "";
            string futureEndPointResolution = "";
            string singlePointType = "";
            string startPointType = "";
            string endPointType = "";
            if (type == Constants.SYS_DATETIME_DATEPERIOD
                || type == Constants.SYS_DATETIME_TIMEPERIOD
                || type == Constants.SYS_DATETIME_DATETIMEPERIOD)
            {
                isPeriod = true;
                switch (type)
                {
                    case Constants.SYS_DATETIME_DATEPERIOD:
                        startPointType = TimeTypeConstants.START_DATE;
                        endPointType = TimeTypeConstants.END_DATE;
                        pastStartPointResolution = FormatUtil.FormatDate(((Tuple<DateObject, DateObject>)ret.PastValue).Item1);
                        pastEndPointResolution = FormatUtil.FormatDate(((Tuple<DateObject, DateObject>)ret.PastValue).Item2);
                        futureStartPointResolution = FormatUtil.FormatDate(((Tuple<DateObject, DateObject>)ret.FutureValue).Item1);
                        futureEndPointResolution = FormatUtil.FormatDate(((Tuple<DateObject, DateObject>)ret.FutureValue).Item2);
                        break;
                    case Constants.SYS_DATETIME_DATETIMEPERIOD:
                        startPointType = TimeTypeConstants.START_DATETIME;
                        endPointType = TimeTypeConstants.END_DATETIME;
                        pastStartPointResolution = FormatUtil.FormatDateTime(((Tuple<DateObject, DateObject>)ret.PastValue).Item1);
                        pastEndPointResolution = FormatUtil.FormatDateTime(((Tuple<DateObject, DateObject>)ret.PastValue).Item2);
                        futureStartPointResolution = FormatUtil.FormatDateTime(((Tuple<DateObject, DateObject>)ret.FutureValue).Item1);
                        futureEndPointResolution = FormatUtil.FormatDateTime(((Tuple<DateObject, DateObject>)ret.FutureValue).Item2);
                        break;
                    case Constants.SYS_DATETIME_TIMEPERIOD:
                        startPointType = TimeTypeConstants.START_TIME;
                        endPointType = TimeTypeConstants.END_TIME;
                        pastStartPointResolution = FormatUtil.FormatTime(((Tuple<DateObject, DateObject>)ret.PastValue).Item1);
                        pastEndPointResolution = FormatUtil.FormatTime(((Tuple<DateObject, DateObject>)ret.PastValue).Item2);
                        futureStartPointResolution = FormatUtil.FormatTime(((Tuple<DateObject, DateObject>)ret.FutureValue).Item1);
                        futureEndPointResolution = FormatUtil.FormatTime(((Tuple<DateObject, DateObject>)ret.FutureValue).Item2);
                        break;
                }
            }
            else
            {
                isSinglePoint = true;
                switch (type)
                {
                    case Constants.SYS_DATETIME_DATE:
                        singlePointType = TimeTypeConstants.DATE;
                        singlePointResolution = FormatUtil.FormatDate((DateObject)ret.FutureValue);
                        break;
                    case Constants.SYS_DATETIME_DATETIME:
                        singlePointType = TimeTypeConstants.DATETIME;
                        singlePointResolution = FormatUtil.FormatDateTime((DateObject)ret.FutureValue);
                        break;
                    case Constants.SYS_DATETIME_TIME:
                        singlePointType = TimeTypeConstants.TIME;
                        singlePointResolution = FormatUtil.FormatTime((DateObject)ret.FutureValue);
                        break;
                }
            }

            if (isPeriod)
            {
                ret.FutureResolution = new Dictionary<string, string>
                {
                    {startPointType, futureStartPointResolution},
                    {endPointType, futureEndPointResolution},
                    {ExtendedModelResult.ParentTextKey, parentText}
                };

                ret.PastResolution = new Dictionary<string, string>
                {
                    {startPointType, pastStartPointResolution},
                    {endPointType, pastEndPointResolution},
                    {ExtendedModelResult.ParentTextKey, parentText}
                };
            }
            else if (isSinglePoint)
            {
                ret.FutureResolution = new Dictionary<string, string>
                {
                    {singlePointType, singlePointResolution},
                    {ExtendedModelResult.ParentTextKey, parentText}
                };

                ret.PastResolution = new Dictionary<string, string>
                {
                    {singlePointType, singlePointResolution},
                    {ExtendedModelResult.ParentTextKey, parentText}
                };
            }
        }
    }
}