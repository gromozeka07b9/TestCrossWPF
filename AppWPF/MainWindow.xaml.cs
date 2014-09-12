using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //var i = PortableCodeLib.MyClass.data;
        }

        void but_Click(object sender, RoutedEventArgs e)
        {
            //var funcResult = PortableCodeLib.MyClass.SendTestRequest();
            //LabResult.Content = PortableCodeLib.MyClass.callResult.ToString();
        }

        private async void LabResult_Loaded(object sender, RoutedEventArgs e)
        {
            PortableCodeLib.MyClass portableclass = new PortableCodeLib.MyClass();
            //Task task = portableclass.TestCall();
            byte[] i = await portableclass.TestCallAsync();
            
            LabResult.Content = System.Text.Encoding.UTF8.GetString(i);

            portableclass.TestWebSrv();
            //string platform = PortableCodeLib.MyClass.GetPlatformName();
            //string platform = SharedCodeLib.TestClass.OSName;
            //Button but = new Button() { Content = platform, Width = 100, Height = 100 };
            //but.Click += but_Click;
            //GridControl.Children.Add(but);
            //LabResult

            /*RestClient client = new RestClient("http://speller.yandex.net/services/spellservice.json/checkText");
            //http://speller.yandex.net/services/spellservice.json/checkText?lang=en&text=%20I%20do%20eror

            var request = new RestRequest();
            request.AddParameter("text", "This example eror", ParameterType.QueryString);
            request.AddParameter("lang", "en", ParameterType.QueryString);
            var result = client.Execute(request);
            var contentresponse = result.Content;*/

        }
    }
}
