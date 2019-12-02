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
using week2;

namespace week5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Student student = new Student();
            InitializeComponent();
        }

        private void pb_hello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF");

        }

        private void pb_hello_GotFocus(object sender, RoutedEventArgs e)
        {
            pb_hello.Content = "Wow !";
        }

        private void pb_bye_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a nice day");
        }

        private void pb_wow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wow");
        }

 
    }
}
