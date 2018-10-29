using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = Student.GetDefaults();
            int howManyInStudentList = studentList.Count();
            var studentNumber = Student.GetStudentNumber(howManyInStudentList);
            int studentIndex = studentNumber - 1;
            var continueProgram = true;
            bool newStudent = true;

            // James - double dos?
            do
            {
                do
                {
                    studentList[studentIndex].PrintIntroQuestion(studentList, studentIndex);

                    string input = Console.ReadLine();
                    Student.PrintExtraInfo(input, studentList, studentIndex);
                    string yesNoAnswer = Console.ReadLine();
                    continueProgram = Student.ContinueTheProgram(yesNoAnswer);

                } while (continueProgram == true);

                Console.WriteLine("Would you like add another student? (y/n) ");
                string newStudentAnswer = Console.ReadLine();

                newStudent = Student.ContinueTheProgram(newStudentAnswer);
                if (newStudent == false)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                
                bool validInput = true;
                studentIndex = studentNumber - 1;
                int studentNum = studentList.Count() + 1;
                string studentNumString = studentNum.ToString();
                string firstName = "";
                do
                {
                    Console.WriteLine("What is the student's first name? ");
                    firstName = Console.ReadLine();
                    if (firstName.Length > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                } while (validInput == false);

                string lastName = "";
                do
                {
                    Console.WriteLine("What is the student's last name? ");
                    lastName = Console.ReadLine();
                    if (lastName.Length > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                } while (validInput == false);

                string homeTown = "";
                do
                {
                    Console.WriteLine("What is the student's hometown? ");
                    homeTown = Console.ReadLine();
                    if (homeTown.Length > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                } while (validInput == false);

                string age = "";
                do
                {
                    Console.WriteLine("What is the student's age? (range from 1-100) ");
                    age = Console.ReadLine();
                    validInput = int.TryParse(age, out int ageNum);
                    if (ageNum > 0 && ageNum < 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                } while (validInput == false);

                string color = "";
                do
                {
                    Console.WriteLine("What is the student's favorite color? ");
                    color = Console.ReadLine();
                    if (color.Length > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                } while (validInput == false);

                studentList.Add(new Student(studentNumString, firstName, lastName, homeTown, age, color));
                int newLengthOfList = studentList.Count();
                studentNumber = Student.GetStudentNumber(newLengthOfList);
                studentIndex = studentNumber - 1;
                
            } while (newStudent);
            Console.ReadKey();

        }      
    }
}
