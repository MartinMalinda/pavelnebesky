using System;
namespace GreenFoxOrganization
{

        //Create a Mentor class that has the same fields and methods as the Person class, and has the following additional

        //fields:
        //level: the level of the mentor(junior / intermediate / senior)


    public class Mentor : Person
    {

        private string level;

        public string Level
        {
            get
            {
                return level;
            }
        }

        //The Mentor class has the following constructors:
        //Mentor(name, age, gender, level)
        //Mentor() : sets name to Jane Doe, age to 30, gender to female, level to intermediate

        public Mentor(string inputName, int inputAge, string inputGender, string inputLevel) : base (inputName, inputAge, inputGender)
        {
            level = inputLevel;
        }

        public Mentor() : base()
        {
            level = "intermediate";
        }

        //methods:
        //GetGoal() : prints out "Educate brilliant junior software developers."
        //Introduce() : "Hi, I'm name, a age year old gender level mentor."

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " " + Level + " mentor.");
        }


    }
}
