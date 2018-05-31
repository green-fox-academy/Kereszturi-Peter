using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFInheritance
{
    class Mentor : Person
    {
        string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            level = "Intermediate";
        }

        public override string GetGoal()
        {
            string goal = "Educate brilliant junior software developers.";
            return goal;
        }

        public override string Introduce()
        {
            string introduce = String.Format("Hi I am {0}, a {1} year old {2} {3} level mentor.", name, age, gender, level); ;
            return introduce;
        }

    }
}
