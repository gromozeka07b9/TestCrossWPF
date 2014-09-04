using System;
using System.Collections;
using System.Collections.Generic;

namespace SD.Portal.Lib
{
    public static class NullHelper
    {
        public static IList<T> AsNotNull<T>(this IList source)
        {
            var resault = source as IList<T> ?? new List<T>();
            return resault;
        }

        public static void WhenNotNull(this object target , Action job)
        {
            if (target != null)
                job();
        }

        public static string AsNotNullString(this object target)
        {
            return target as string ?? string.Empty;
        }
    }
}