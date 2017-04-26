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

            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(@"http://localhost:55676/api/main").Result;
            string message = response.Content.ReadAsStringAsync().Result;
            JavaScriptSerializer jss = new JavaScriptSerializer();

            string content = jss.Deserialize<string>(message);

            textBlock.Text = content;
        }
    }
}
