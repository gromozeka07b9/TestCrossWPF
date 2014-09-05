using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCodeLib
{
    public class TestClass
    {
        public static int Test = 0;
        public static string OSName
        {
            get{
                string Os = string.Empty;
/*#if __ANDROID__
                Os = "Android";
#elif __IOS__
                Os = "Ios";
#elif __WINDOWS_PHONE__
                Os = "WinPhone";
#else
                Os = "WPF";
#endif*/
#if __ANDROID__
                Os = "Android";
#endif
                if (Os != "Android") Os = "WPF";
                return Os;
            }
        }
    }
}
