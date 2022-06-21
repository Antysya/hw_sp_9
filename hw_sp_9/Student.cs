using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_sp_9
{
    public delegate void ExamDel(string str); //2
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Skipping_class { get; set; }
        public int Homework { get; set; }

        public override string ToString()
        {
            return $" {LastName}\t{FirstName}\t{BirthDate.ToShortDateString()}\t{Skipping_class}\t{Homework}";
        }

        public void Exam(string task) //1
        {
            WriteLine($" {LastName}\t{FirstName}\t{Skipping_class}\t{Homework} - {task}");
        }
    }

    class Teacher
    {
        public event ExamDel ExamEvent; //3
        public void Exam(string task)//1.2
        {
            if (ExamEvent != null)
                ExamEvent(task);
        }
    }

}
