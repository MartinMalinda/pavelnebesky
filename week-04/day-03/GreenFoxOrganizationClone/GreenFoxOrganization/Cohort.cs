using System;
using System.Collections.Generic;

namespace GreenFoxOrganization
{

    //Create a Cohort class that has the following

    //fields:
    //name: the name of the cohort
    //students: a list of Students
    //mentors: a list of Mentors
    
    

    public class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public List<Mentor> Mentors
        {
            get
            {
                return mentors;
            }
        }



        //The Cohort class has the following constructors:
        //Cohort(name) : beside the given parameter, it sets students and mentors as empty lists

        public Cohort(string inputName)
        {
            name = inputName;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        //methods:
        //addStudent(Student) : adds the given Student to students list
        // addMentor(Mentor): adds the given Mentor to mentors list
        // info(): prints out "The name cohort has students.size() students and mentors.size() mentors."

        public void AddStudent (Student inputStudent)
        {
            students.Add(inputStudent);
        }

        public void AddMentor(Mentor inputMentor)
        {
            mentors.Add(inputMentor);
        }

        public void Info ()
        {
            Console.WriteLine("The " + name + " cohort has " + students.Count + " students and " + mentors.Count + " mentors.");
        }

    }
}
