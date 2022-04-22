using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lesson291119
{
    class Human
    {
        private string name { get; set; }
        private string lastname { get; set; }
        public Human(string name,string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }
        public virtual void Print()
        {
            Console.WriteLine("Имя: "+ name);
            Console.WriteLine("Фамилия: " + lastname);
        }
    }
    class Student:Human
    {
        protected string place { get; set; }
        public Student(string name,string lastname ,string place): base(name,lastname)
        {
            this.place = place;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Место обучения: " + place);
        }
    }
    class Course:Student
    {
     private int course { get; set; }
        public Course(string name, string lastname, string place,int course) : base (name, lastname,place)
        {
            this.course = course;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Курс: " + course);
        }
    }
    class Костюлин
    {
        static void Main(string[] args)
        {
            Course denis = new Course("Денис","Костюлин","ЮФУ",1);
            denis.Print();
            Console.WriteLine("");
            Student artyom = new Student("Артем", "Булатецкий", "Заборостроительный университет");
            artyom.Print();
            Console.ReadLine();
        }
    }
}
