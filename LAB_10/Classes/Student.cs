using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_10.Classes
{
    class Student : Training
    {
        protected string Faculty;

        public Student() : base()
        {

        }

        public Student(string firstName, string lastName, int age, string placeOfStudy, string faculty) : base(firstName, lastName, age, placeOfStudy)
        {
            this.Faculty = faculty;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Study: {this.PlaceOfStudy}\nFaculty: {this.Faculty}";
        }

        public override void Learn()
        {
            Console.WriteLine("Хожу на все пары и пишу конспекты!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Сплю на парах!!!");
        }

    }
}
