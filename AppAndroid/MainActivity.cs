using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AppAndroid
{
	[Activity (Label = "AppAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override async void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
            //string platform = SharedCodeLib.TestClass.OSName;
            //string platform = PortableCodeLib.MyClass.GetPlatformName();
            //button.Text = PortableCodeLib.MyClass.GetTestString() + ", platform:" + platform;
            PortableCodeLib.MyClass portableclass = new PortableCodeLib.MyClass();
            byte[] i = await portableclass.TestCallAsync();

            string result = System.Text.Encoding.UTF8.GetString(i);

            button.Text = result;
			button.Click += delegate {
				//button.Text = string.Format ("{0} clicks! test", count++);
                //var funcResult = PortableCodeLib.MyClass.SendTestRequest();
                //button.Text = button.Text + PortableCodeLib.MyClass.callResult.ToString();
                portableclass.TestWebSrv();

			};

        }
	}
}


