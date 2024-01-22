using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Structures
{
    internal class Program
    {
        struct pokemon
        {
            public int id;
            public string name;
            public int level;
        }
        struct student
        {
            public string name;
            public int grade;
            public int age;
            public gender gender;
            public decimal GPA;
        }
        struct holiday
        {
            public string name;
            public day day;
        }
        enum gender { male, female };
        enum day {M, T, W, Th, F};
        static void Main(string[] args)
        {
            pokemon pikachu = new pokemon();
            pikachu.name = "Robbie";
            pikachu.level = 1;
            pikachu.id = 1;

            student student= new student();
            student.name = "Robbie";
            student.grade = 11;
            student.gender = gender.male;

            holiday holiday = new holiday();
            holiday.name = "MLK day";
            holiday.day = day.M;
        }
    }
}
