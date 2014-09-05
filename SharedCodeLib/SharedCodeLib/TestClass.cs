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
#if __ANDROID__
                Os = "Android";
#endif
#if __IOS__
				Os = "IOS";
#endif
#if __WINDOWS_PHONE__
				Os = "WinPhone";
#endif
				if (string.IsNullOrEmpty(Os)) Os = "WPF";
                return Os;
            }
        }
    }
}
