﻿using System;
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

        public static int GetStudentNumber()
        {
            Console.WriteLine("Welcome to our C# class. Which student would you " +
                 "like to learn about? (enter a number 1-20): ");
            string studentNumberInput = Console.ReadLine();
            bool realNumber = int.TryParse(studentNumberInput, out int studentNumber);

            while (realNumber == false || studentNumber<1 || studentNumber > 20)
            {
                Console.WriteLine("Please enter a number between 1 and 20: ");
                studentNumberInput = Console.ReadLine();
                realNumber = int.TryParse(studentNumberInput, out studentNumber);
            }
            return studentNumber;
        }

        public void PrintIntroQuestion(List<Student> studentData, int studentIndex)
        {
            string studentNumber = studentData[studentIndex]._studentNumber;
            string firstName = studentData[studentIndex]._firstName;
            string lastName = studentData[studentIndex]._lastName;
            Console.WriteLine($"Student {studentNumber} is {firstName} {lastName}. What would you like to know about {firstName}? (enter 'hometown' or 'age'): ");
        }

        public static void PrintExtraInfo(string info, List<Student> studentData, int studentIndex)
        {
            bool validInput = false;
            while (validInput == false)
            {
                if (info.Equals("hometown", StringComparison.OrdinalIgnoreCase))
                {
                    Student.PrintHomeTown(studentData, studentIndex);
                    validInput = true;
                }
                else if (info.Equals("age", StringComparison.OrdinalIgnoreCase))
                {
                    Student.PrintAge(studentData, studentIndex);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't get that.  Please enter age or hometown: ");
                    validInput = false;
                }
                info = Console.ReadLine();
            }
        }

        public static void PrintHomeTown(List<Student> studentData, int studentIndex)
        {
            string firstName = studentData[studentIndex]._firstName;
            string homeTown = studentData[studentIndex]._homeTown;
            Console.WriteLine($"{firstName} is from {homeTown}. Would you like to know more? (y/n) ");
        }

        public static void PrintAge(List<Student> studentData, int studentIndex)
        {
            string firstName = studentData[studentIndex]._firstName;
            string age = studentData[studentIndex]._age;
            Console.WriteLine($"{firstName} is {age} years old. Would you like to know more? (y/n)");
        }

        public static List<Student> GetDefaults()
        {
            List<Student> studentData = new List<Student>();
            studentData.Add(new Student("1", "Bob", "Smith", "Detroit, MI", "20"));
            studentData.Add(new Student("2", "Cody", "Jenkins", "Royal Oak, MI", "28"));
            studentData.Add(new Student("3", "Josh", "O'Connor", "Berkley, MI", "18"));
            studentData.Add(new Student("4", "Kara", "Gheldof", "Royal Oak, MI", "32"));
            studentData.Add(new Student("5", "Brandon", "Quinn", "Detroit, MI", "40"));
            studentData.Add(new Student("6", "Raven", "Caswell", "Chicago, IL", "22"));
            studentData.Add(new Student("7", "Les", "Potter", "Detroit, MI", "25"));
            studentData.Add(new Student("8", "Jennifer", "Williams", "Troy, MI", "35"));
            studentData.Add(new Student("9", "Jeff", "Stevens", "Grosse Point, MI", "40"));
            studentData.Add(new Student("10", "Zach", "Hobart", "Houston, TX", "35"));
            studentData.Add(new Student("11", "Adam", "Reeds", "Detroit, MI", "25"));
            studentData.Add(new Student("12", "Kelsey", "Taylor", "Oak Park, MI", "32"));
            studentData.Add(new Student("13", "Colleen", "Ewald", "Redford, MI", "28"));
            studentData.Add(new Student("14", "Joseph", "Harrison", "Troy, MI", "21"));
            studentData.Add(new Student("15", "William", "McKay", "Hazel Park, MI", "20"));
            studentData.Add(new Student("16", "Charlotte", "Left", "Lake Orion, MI", "39"));
            studentData.Add(new Student("17", "Marnie", "Fargel", "Toledo, OH", "45"));
            studentData.Add(new Student("18", "Liam", "Piper", "Holland, MI", "42"));
            studentData.Add(new Student("19", "Craig", "Jones", "Farmington Hills, MI", "33"));
            studentData.Add(new Student("20", "John", "Smith", "Novi, MI", "32"));
            return studentData;
        }

    }
}
