using System;

namespace teachersAndStudents
{
    class Program
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

        static void Main(string[] args)
        {

            Student studentOne = new Student("John Doe", 20);
            Student studentTwo = new Student("Jane Write", 19);
            Teacher teacherOne = new Teacher("Jim Cool", 50);
            Teacher teacherTwo = new Teacher("Mat Huge", 46);

            studentOne.Learn();
            teacherOne.Answer();
            studentOne.Question(teacherOne);
            teacherOne.Teach(studentOne);

        }
    }
}
