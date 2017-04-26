using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

using System.Web.Script.Serialization;
using System.Net.Http.Formatting;

namespace WPFsimple
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person() { Name = "Satenik", Age = 20 };
            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.PostAsync(@"http://http://localhost:51001/api/main", p, new JsonMediaTypeFormatter()).Result;
            string message = response.Content.ReadAsStringAsync().Result;

            JavaScriptSerializer jss = new JavaScriptSerializer();

            string content = jss.Deserialize<string>(message);

            textBlock.Text = content;
        }
    }
}
