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

namespace week2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student[] students;
        public MainWindow()
        {
            students = new Student[10];
            int length = students.Length;
            InitializeComponent();
        }

        private void pbConsole_Click(object sender, RoutedEventArgs e)
        {
            //int num2;
            //Int32.TryParse(tbConsole.Text,out num2);
            //try
            //{
            //    int num = Int32.Parse(tbConsole.Text);
            //    tbConsole.Text = "Welcome " + num;
            //}
            //catch (Exception ex)
            //{

            //    tbConsole.Text = ex.Message;
            //}
            //finally
            //{
            //    tbConsole.Text = tbConsole.Text + "\n";
            //    tbConsole.Text = tbConsole.Text + "Try again";
            //}

            Student st = new Student(tbConsole.Text);
           // st.Id = 5;
            tbConsole.Text = "Welcome " + st + st.Id;


        }
    }
}
