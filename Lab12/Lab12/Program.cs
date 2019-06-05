using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Student> student = new List<Student>();
            List<Teacher> teacher = new List<Teacher>();

            using (StreamReader reader = new StreamReader(@"../../Date.in"))
            {
                string line;
                string[] tokens;
                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (line == "")
                        break;
                   // Console.WriteLine(line);
                    tokens = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    //Console.WriteLine(string.Join(" ", tokens));
                    string type = tokens[0];
                 
                   
                
                    string fullname = tokens[1];
                    string birthdate = tokens[2];
                    string[] names = fullname.Split(' ');
                    string[] dates = birthdate.Split('.');
                    int[] intDates = null;
                    try
                    {
                         intDates = new int[] {
                        int.Parse(dates[0]),
                        int.Parse(dates[1]),
                        int.Parse(dates[2]) };
                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Invalid date!");
                        return;
                            
                    }
                    DateTime birth = new DateTime(intDates[2], intDates[1], intDates[0]);
                    string materie = "";
                    if (type != "P")
                        materie = tokens[3];
                    switch (type)
                    {
                        case "P":
                            {
                                people.Add(new Person(names[0], names[1], birth));
                            }break;
                        case "T":
                            {
                                teacher.Add(new Teacher(names[0], names[1], birth, materie));
                            }break;
                        case "S":
                            {
                                student.Add(new Student(names[0], names[1], birth,materie));
                            }break;

                    }
                }
               

            }
            teacher.Sort(Person.CompareName);
            for (int i = 0; i < teacher.Count; i++)
            {
                Console.WriteLine(teacher[i].Name+" "+teacher[i].Surname);
            }
            student.Sort(Person.CompareName);
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine(student[i].Name + " " + student[i].Surname);

                student[i].GotoClasses();
                student[i].ShowAge();
            }




        }
    }
}
