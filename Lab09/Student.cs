using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Student
    {
        private string _studentNumber;
        private string _firstName;
        private string _lastName;
        private string _homeTown;
        private string _age;

        public Student(string studentNumber, string firstName, string lastName, string homeTown, string age)
        {
            _studentNumber = studentNumber;
            _firstName = firstName;
            _lastName = lastName;
            _homeTown = homeTown;
            _age = age;
        }

        public void PrintIntroQuestion(List<Student> studentData, int studentIndex)
        {
            string studentNumber = studentData[studentIndex]._studentNumber;
            string firstName = studentData[studentIndex]._firstName;
            string lastName = studentData[studentIndex]._lastName;
            Console.WriteLine($"")


        }

        public void PrintHomeTown(List<Student> studentData, int studentIndex)
        {
            string firstName = studentData[studentIndex]._firstName;
            string homeTown = studentData[studentIndex]._homeTown;
            Console.WriteLine($"{firstName} is from {homeTown}. Would you like to know more? (y/n) ");
        }

        public void PrintAge(List<Student> studentData, int studentIndex)
        {
            string firstName = studentData[studentIndex]._firstName;
            string age = studentData[studentIndex]._age;
            Console.WriteLine($"{firstName} is {age} years old. Would you like to know more? (y/n)");
        }


    }
}
