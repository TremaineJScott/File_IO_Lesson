using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Lesson
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double HourlyWage { get; set; }
        public int EmploymentYears { get; set; }

        public User(string first, string last, int age, double wage, int years)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            HourlyWage = wage;
            EmploymentYears = years;
        }
    }

}
