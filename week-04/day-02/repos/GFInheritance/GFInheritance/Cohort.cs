using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFInheritance
{
    class Cohort
    {
        string name;
        public List<Mentor> mentors = new List<Mentor>();
        public List<Student> students = new List<Student>();

        public Cohort(string name)
        {
            this.name = name;
        }
        
        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public string Info()
        {
            return String.Format("The {0} cohort has {1} students and {2} mentors.", 
                name, students.Count, mentors.Count);
        }
    }
}
