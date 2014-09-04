using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.Portal.Lib
{
    public static class DateTimeHelper
    {
        public static DateTime EndOfDay(this DateTime arg)
        {
            return arg.Date.AddDays(1).AddTicks(-1);
        }
    }
}
