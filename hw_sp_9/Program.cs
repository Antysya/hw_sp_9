using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_sp_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            List<Student> group = new List<Student> {
                new Student {
                FirstName = "John",
                LastName = "Miller",
                BirthDate = new DateTime(1997,3,12),
                Skipping_class = rn.Next(0, 10),
                Homework = rn.Next(0, 50)
                },
                new Student {
                FirstName = "Candice",
                LastName = "Leman",
                BirthDate = new DateTime(1998,7,22),
                Skipping_class = rn.Next(0, 10),
                Homework = rn.Next(0, 50)
                },
                new Student {
                FirstName = "Joey",
                LastName = "Finch",
                BirthDate = new DateTime(1996,11,30),
                Skipping_class = rn.Next(0, 10),
                Homework = rn.Next(0, 50)
                },
                new Student {
                FirstName = "Nicole",
                LastName = "Taylor",
                BirthDate = new DateTime(1996,5,10),
                Skipping_class = rn.Next(0, 10),
                Homework = rn.Next(0, 50)
                },
                new Student {
                FirstName = "Olof",
                LastName = "Fly",
                BirthDate = new DateTime(1996,5,10),
                Skipping_class = rn.Next(0, 10),
                Homework = rn.Next(0, 50)
                }
            };

            Teacher t = new Teacher();
            Teacher t2 = new Teacher();

            WriteLine("****Допуск****");
            foreach (Student item in group)
            {
                if (item.Skipping_class < 4 && item.Homework > 40)
                    t.ExamEvent += item.Exam;
                if (item.Skipping_class >= 4 || item.Homework < 40)
                    t2.ExamEvent += item.Exam;
            }

            t.Exam("допущен к экзамену");
            t2.Exam("к экзамену не допущен");
        }
    }
}

