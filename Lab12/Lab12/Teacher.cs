using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Teacher:Person
    {
        string subject;
        public string Subject
        {
            get
            {
                return subject;
            }
        }
        public Teacher(string name, string surname, DateTime birthDate,string subject)
            :base(name,surname,birthDate)
        {
            this.subject = subject;
        }
        public void Explain()
        {
            Console.WriteLine($"Explaining begins!I explain {subject}");
        }
        
    }
}
