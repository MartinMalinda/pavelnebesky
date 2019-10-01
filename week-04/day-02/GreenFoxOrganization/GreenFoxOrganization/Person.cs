using System;
namespace GreenFoxOrganization
{

    //Create a Person class with the following fields:

    //name: the name of the person
    //age: the age of the person(whole number)
    //gender: the gender of the person(male / female)
    //And the following methods:

    //Introduce() : prints out "Hi, I'm name, a age year old gender."
    //GetGoal() : prints out "My goal is: Live for the moment!"
    //And the following constructors:

    //Person(name, age, gender)
    //Person() : sets name to Jane Doe, age to 30, gender to female


    public class Person
    {

        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";

        }

        public Person(string inputName, int inputAge, string inputGender)
        {
            name = inputName;
            age = inputAge;
            gender = inputGender;

        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }
}
