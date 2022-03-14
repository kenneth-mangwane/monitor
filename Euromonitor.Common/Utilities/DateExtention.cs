using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euromonitor.Common.Utilities
{
    public static class DateExtensions
    {
        public static string DateFormatL(this DateTime date, bool includeTime = false, bool includeSec = false)
        {
            return date.ToString("ddd, MMMM dd yyyy HH:mm");
        }
        public static string DateFormatL(this DateTime date)
        {
            return date.ToString("ddd, MMMM dd yyyy HH:mm");
        }
        /// <summary>
        /// Default format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string DateFormat(this DateTime date)
        {
            return date.ToString("ddd, MMMM dd yyyy HH:mm:ss");
        }
        /// <summary>
        /// Web format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string DateWebFormat(DateTime date)
        {
            return date.ToString("ddd, MMMM dd yyyy");
        }
        /// <summary>
        /// Timeline format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string DateTimelineFormat(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm");
        }
        /// <summary>
        /// Comment format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string DateCommentFormat(DateTime date)
        {
            return date.ToString("ddd, MMMM dd yyyy HH:mm:ss");
        }
        /// <summary>
        /// Mobile format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string DateMobileFormat(DateTime date)
        {
            DateTime today = DateTime.Now;
            string datestring = "";
            if (date.Day == today.Day)
            {
                //16:32
                datestring = date.ToString("HH:mm");
            }
            else if (date.AddDays(1).Day == today.Day)
            {
                //Yesterday, 16:32
                datestring = "Yesterday, " + date.ToString("HH:mm");
            }
            else
            {
                //Mon, May 25 2019 16:32
                datestring = date.ToString("ddd, MMMM dd yyyy HH:mm");
            }
            return datestring;
        }
        /// <summary>
        /// Mobile innner 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string DateMobileInnerDetails(DateTime date)
        {
            //return and re-edit
            return date.ToString("HH:mm:ss");
        }
        /// <summary>
        /// Mobile side
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string DateMobileSide(DateTime date)
        {
            DateTime today = DateTime.Now;
            string returnDate = null;
            if (today.Date == date.Date)
            {
                returnDate = "Today";
            }
            else if (today.AddDays(-1).Date == date.Date)
            {
                returnDate = "Yesterday";
            }
            else
            {
                returnDate = date.ToString("dd ddd");
            }
            return returnDate;
        }

        /// <summary>
        /// mobile month int to string
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public static string MonthIntToString(int month)
        {
            string monthString = null;
            switch (month)
            {
                case 1:
                    monthString = "Jan";
                    break;

                case 2:
                    monthString = "Feb";
                    break;

                case 3:
                    monthString = "Mar";
                    break;

                case 4:
                    monthString = "Apr";
                    break;

                case 5:
                    monthString = "May";
                    break;

                case 6:
                    monthString = "Jun";
                    break;

                case 7:
                    monthString = "July";
                    break;

                case 8:
                    monthString = "Aug";
                    break;

                case 9:
                    monthString = "Sep";
                    break;

                case 10:
                    monthString = "Oct";
                    break;

                case 11:
                    monthString = "Nov";
                    break;

                case 12:
                    monthString = "Dec";
                    break;

            }
            return monthString;
        }

        /// <summary>
        /// month to mobile format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string MonthMobileFormat(DateTime date)
        {
            return date.ToString("MMMM yyyy");
        }

    }

}
