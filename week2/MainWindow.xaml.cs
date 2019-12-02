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
            Random rand = new Random(DateTime.Now.Millisecond);
            students = new Student[10];
            int length = students.Length;
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("a", rand.Next(1980,2000));
            }
         
            List<Student> studentList = students.ToList();
            studentList.Sort();
            //studentList.FindAll()
            var newStudentList =  studentList.FindAll(st => st.Average > 80);
         //   studentList.Sum();


            String str = "Hello";
            String str2 = " World";

           str += str2 += " \n";

            char c = str[3];
            
            DateTime dt =  Convert.ToDateTime("11/11/2019");
            //str[3] = 'a';
            var anonymousObject = new { Id = 2222, Name = "Yossi" , Age = 30};
            var anonymousObject2 = new { Id = 2222, Name = "Yair" };

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

            Person p = st; // c++ equil Person *p = &st;


            if (p is Student)
            {

                tbConsole.Text = tbConsole.Text + "\n";
                tbConsole.Text = tbConsole.Text + p.GetType() + "\n";
                tbConsole.Text = tbConsole.Text + (p as Student).Average;

            }

            tbConsole.Text += dp_StartVacation.SelectedDate.ToString();
            
            DateTime dateTime = dp_StartVacation.SelectedDate.Value;
        }
    }
}
