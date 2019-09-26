using System;
namespace teachersAndStudents
{

    //Create Student and Teacher classes
    //Student
    //Learn() -> prints the student is learning something new
    //Question(teacher) -> calls the teachers answer method
    //Teacher
    //Teach(student) -> calls the students learn method
    //Answer() -> prints the teacher is answering a question
    //Instantiate a Student and Teacher object
    //Call the student's Question() method and the teacher's Teach() method

    public class Teacher
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Teacher(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Answer()
        {
            Console.WriteLine(Name + " age " + Age + " is answering a question.");
        }

        public void Teach(Student student)
        {
            Console.Write(Name + " age " + Age + " is teaching now. ");
            student.Learn();
        }

    }
}
