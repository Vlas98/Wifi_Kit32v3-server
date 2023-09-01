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
using System.Timers;
using System.IO.Ports;
using System.Threading;

namespace TelegramBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        SerialPort currentPort = new SerialPort("COM5", 115200, Parity.None); //crate object SerialPort and add port's configs

        public MainWindow()
        {
            InitializeComponent();          //initialization all components in server
            currentPort.Open();             // open port
            System.Console.WriteLine("Port is open"); //wtite log

        }

        private void clear(object sender, RoutedEventArgs e)
        {
            currentPort.Write("clear");     //send command "clear" for clear display
            Text.Text = "";                 //clear texbox
        }

        private void send(object sender, RoutedEventArgs e)
        {
           string sendingText = Text.Text;  //create variable "sendingText" equil text from TextBox "Text"
            currentPort.Write(sendingText); // send text to port
            Text.Text = "";                 // clear textbox
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
