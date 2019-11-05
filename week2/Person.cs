using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class Person
    {
        private string _name;
        private DateTime _birthday;

        public Person(string name = "", int year = 1970, int month = 1, int day = 1)
        {
            _name = name;
            _birthday = new DateTime(year, month, day);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Birthday
        { get => _birthday; set => _birthday = value; }

        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }
    }
}
