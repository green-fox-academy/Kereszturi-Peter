using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFInheritance
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public override string GetGoal()
        {
            string goal = "Hire brilliant junior software developers.";
            return goal;
        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            hiredStudents = 0;
        }

        public Sponsor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            company = "Google";
            hiredStudents = 0;
        }

        public override string Introduce()
        {
            string introduce = String.Format("Hi I am {0}, a {1} year old {2} {3}, who represents {4} and hired {5} students so far.", name, age, gender, company, hiredStudents); ;
            return introduce;
        }

        public int Hire()
        {
            return hiredStudents++;
        }
    }
}
