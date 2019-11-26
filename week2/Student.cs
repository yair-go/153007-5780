using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class Student : Person
    {
        private int _average;

        public Student(string name ="", int year = 1970, int month = 1, int day = 1, int average = 100) : base(name,year,month,day)
        {
            _average = average;
        }

        public int Average { get => _average; set => _average = value; }

        public override string ToString()
        {
            return base.ToString() + " " + _average;
        }

        public String Something()
        {
            throw new System.NotImplementedException();
        }
    }
}
