using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFInheritance
{
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public virtual string Introduce()
        {
            string introduce = String.Format("Hi I am {0}, a {1} year old {2}.", name, age, gender); ;
            return introduce;
        }

        public virtual string GetGoal()
        {
            string goal = "My goal is: Live for the moment!";
            return goal;
        }
    }
}
