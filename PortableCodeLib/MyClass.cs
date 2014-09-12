using RestSharp.Portable;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PortableCodeLib
{
    public class CheckResponse
    {
        public string code;
        public string pos;
        public string row;
        public string col;
        public string len;
        public string word;
    }
    
    public class MyClass
	{
		public string TestResult = string.Empty;
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

		public async Task<byte[]> TestCallAsync()
		{
            var client = new RestClient("http://speller.yandex.net/services/spellservice.json/checkText");
            var request = new RestRequest("http://speller.yandex.net/services/spellservice.json/checkText", HttpMethod.Get);
            request.AddParameter("text", "This example eror", ParameterType.QueryString);
            request.AddParameter("lang", "en", ParameterType.QueryString);
            var result = await client.Execute(request);
            return result.RawBytes;

		}

        public void TestWebSrv()
        {
            Service1Client client = new Service1Client();
            client.GetDataCompleted += client_GetDataCompleted;
            client.GetDataAsync(10);
        }

        void client_GetDataCompleted(object sender, GetDataCompletedEventArgs e)
        {
			if (e.Error != null)
			{
				throw new Exception("Error 222!");
			}
			else
			{
				TestResult = e.Result;
			}            
        }
        //public static EventHandler<DailyInfo..GetCursDynamicCompletedEventArgs> SendTestRequest()
        //public static EventHandler<YandexSpellChecker.checkTextCompletedEventArgs> SendTestRequest()
        //{
            /*DailyInfo.DailyInfoSoapClient client = new DailyInfo.DailyInfoSoapClient();
            client.GetCursDynamicCompleted += client_GetCursDynamicCompleted;
            client.GetCursDynamicAsync(DateTime.Now.AddDays(-4), DateTime.Now, "R01090");*/
            /*YandexSpellChecker.SpellServiceSoapClient client = new YandexSpellChecker.SpellServiceSoapClient();
            client.checkTextCompleted += client_checkTextCompleted;
            client.checkTextAsync("Ниопределенность", "Ru", 0, "");*/
            //ExchangeService.SimpleExchangeServiceClient client = new ExchangeService.SimpleExchangeServiceClient();
            //client.PingCompleted += client_PingCompleted;
            //client.PingAsync();
        //    return client_checkTextCompleted;
        //}

        /*static void client_GetCursDynamicCompleted(object sender, DailyInfo.GetCursDynamicCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        /*static void client_checkTextCompleted(object sender, YandexSpellChecker.checkTextCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }*/
	}
}

