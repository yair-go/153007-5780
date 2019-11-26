using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class Person : IComparable
    {
        #region Fields
        private string _name;
        private DateTime _birthday;
        private static int s_id  = 1;
        private int _id;
        #endregion

        #region Ctors
        public Person(string name = "", int year = 1970, int month = 1, int day = 1)
        {
            this._id =s_id;
            s_id++;
            _name = name;
            _birthday = new DateTime(year, month, day);

        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Id { get { return _id.ToString("00000000"); } }

        public DateTime Birthday
        { get => _birthday; set => _birthday = value; }

        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }

        public int CompareTo(object obj)
        {
            return this.Age.CompareTo((obj as Person).Age);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return Name + " " + Age + "  " + Id;
        }
        #endregion
    }
}
