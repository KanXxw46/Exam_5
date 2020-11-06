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
using Twilio.TwiML.Messaging;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Examen_5
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0))
            {
                return;
            }
            e.Handled = true;
        }
        private bool isWindowAlreadyOpen = false;
        string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!isWindowAlreadyOpen)
            {
                Button button = new Button();
                button.Show();
                button.Topmost = true;
                isWindowAlreadyOpen = true;
            }
            Console.WriteLine(Message.Sid);
        }

    }
}
