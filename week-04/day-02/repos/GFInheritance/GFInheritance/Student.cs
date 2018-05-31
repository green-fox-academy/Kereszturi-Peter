using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFInheritance
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public override string GetGoal()
        {
            string goal = "Be a junior software developer.";
            return goal;
        }

        public override string Introduce()
        {
            string introduce = String.Format("Hi I am {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.",
                name, age, gender, previousOrganization, skippedDays);
            return introduce;
        }

        public int SkipDays(int numberOfDays)
        {
            return skippedDays += numberOfDays;
        }
    }   
}
