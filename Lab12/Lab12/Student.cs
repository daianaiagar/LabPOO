using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Student:Person
    {
        public string specializare;
        public Student(string name, string surname, DateTime birthDate,string specializare)
            :base(name,surname,birthDate)
        {
            this.specializare = specializare;

        }
        public void GotoClasses()
        {
            Console.WriteLine($"I am going to class.I study {specializare}");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is {this.Age} years old");

        }

    }
}
