using System;
namespace GreenFoxOrganization
{
    //Create a Student class that has the same fields and methods as the Person class,
    //and has the following additional

    //fields:
    //previousOrganization: the name of the student’s previous company / school
    //skippedDays: the number of days skipped from the course


    public class Student : Person , ICloneable
    {
        private string previousOrganization;
        private int skippedDays;

        public string PreviousOrganization
        {
            get
            {
                return previousOrganization;
            }
        }

        public int SkippedDays
        {
            get
            {
                return skippedDays;
            }
        }

        //The Student class has the following constructors:
        //Student(name, age, gender, previousOrganization) : beside the given parameters, it sets skippedDays to 0
        //Student() : sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0

        public Student() : base("Jane Doe", 30, "female")
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public Student(string inputName, int inputAge, string inputGender, string inputPreviousOrganization) : base(inputName, inputAge, inputGender)
        {
            previousOrganization = inputPreviousOrganization;
            skippedDays = 0;
        }

        //methods:
        //GetGoal() : prints out "Be a junior software developer."
        //Introduce() : "Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already."
        //SkipDays(numberOfDays) : increases skippedDays by numberOfDays

        //public object Clone(Student inputStudent)
        //{
        //    return inputStudent.MemberwiseClone();
        //}

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " from " + PreviousOrganization + " who skipped " + SkippedDays + " days from the course already.");
        }

        public void SkipDays (int numberOfDays)
        {
            skippedDays += numberOfDays;   
        }

        public object Clone()
        {
            return new Student(Name, Age, Gender, PreviousOrganization);
        }

    }
}
