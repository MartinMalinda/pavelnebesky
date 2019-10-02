using System;
namespace GreenFoxOrganization
{

    //fields:
    //company: name of the company
    //hiredStudents: number of students hired
    //method:


    
    public class Sponsor : Person
    {

        private string company;
        private int hiredStudents;

        public string Company
        {
            get
            {
                return company;
            }
        }

        public int HiredStudents
        {
            get
            {
                return hiredStudents;
            }
        }

        //The Sponsor class has the following constructors:
        //Sponsor(name, age, gender, company) : beside the given parameters, it sets hiredStudents to 0
        //Sponsor() : sets name to Jane Doe, age to 30, gender to female, company to Google and hiredStudents to 0

        public Sponsor(string inputName, int inputAge, string inputGender, string inputCompany) : base(inputName, inputAge, inputGender)
        {
            company = inputCompany;
            hiredStudents = 0;
        }

        public Sponsor() : base()
        {
            company = "Google";
            hiredStudents = 0;
        }

        //Introduce() : "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
        //Hire() : increase hiredStudents by 1
        //GetGoal() : prints out "Hire brilliant junior software developers."

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " who represents " + Company + " and hired " + HiredStudents + " so far.");
        }

        public void Hire()
        {
            hiredStudents++;
        }

    }
}
