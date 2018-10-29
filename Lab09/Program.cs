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
       
                

                studentIndex = studentNumber - 1;
                int studentNum = studentList.Count() + 1;
                string studentNumString = studentNum.ToString();
                Console.WriteLine("What is the student's first name? ");
                string firstName = Console.ReadLine();
                Console.WriteLine("What is the student's last name? ");
                string lastName = Console.ReadLine();
                Console.WriteLine("What is the student's hometown?");
                string homeTown = Console.ReadLine();
                Console.WriteLine("What is the student's age? ");
                string age = Console.ReadLine();

                studentList.Add(new Student(studentNumString, firstName, lastName, homeTown, age));
                int newLengthOfList = studentList.Count();
                studentNumber = Student.GetStudentNumber(newLengthOfList);
                studentIndex = studentNumber - 1;
                

            } while (newStudent);
            Console.ReadKey();

        }


        
    }
}
