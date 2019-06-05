using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Person
    {

        protected string name, surname;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        public static PeopleNameComparer CompareName{
            get
            {
                return new PeopleNameComparer();
            }
            }
        protected DateTime birthDate;
        public Person( string name, string surname,DateTime birthDate)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
        }
        public int Age
        {
            get
            {
                return (DateTime.Now - birthDate).Days / 365;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
        }

    }
}
