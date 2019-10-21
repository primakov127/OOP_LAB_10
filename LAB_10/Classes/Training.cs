using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_10.Classes
{
    abstract class Training : Person
    {
        protected string PlaceOfStudy;

        protected Training() : base()
        {
        }

        protected Training(string firstName, string lastName, int age, string placeOfStudy) : base(firstName, lastName, age)
        {
            this.PlaceOfStudy = placeOfStudy;
        }

        public override void GetMoney()
        {
            Console.WriteLine("Получаю стипендию и беру деньги у родителей!");
        }

        public abstract void Learn();
    }
}
