using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            Console.Write("Adinizi daxil edin: ");
            student1.Name = Console.ReadLine();

            Console.Write("Soyadinizi daxil edin: ");
            student1.Surname = Console.ReadLine();

            Group studentGroup = new Group();
            Console.Write("Qrupunuzu daxil edin: ");
            studentGroup.Groupname = Console.ReadLine();

            Console.WriteLine($"Salam {student1.Fullname()}.Sizin Qrupunuz {studentGroup.Groupname}");
            Console.ReadLine();
        }

    }

     class Group
    {

        public string Groupname { get; set; }

    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Fullname()
        {
            return Name + " " + Surname;
        }
    }
}
