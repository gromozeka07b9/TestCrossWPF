using System;

namespace PortableCodeLib
{
	public class MyClass
	{
		public MyClass ()
		{
		}

		public static string GetTestString ()
		{
			return "teststring";
		}

        public static string GetPlatformName()
        {
            return SharedCodeLib.TestClass.OSName;
        }
	}
}

