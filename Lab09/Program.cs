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
            var studentNumber = Student.GetStudentNumber();

            int studentIndex = studentNumber - 1;
            var studentList = Student.GetDefaults();

            studentList[studentIndex].PrintIntroQuestion(studentList, studentIndex);

            string input = Console.ReadLine();

            Student.PrintExtraInfo(input, studentList, studentIndex);
            string yesNoAnswer = Console.ReadLine();


            //studentList[studentIndex].PrintHomeTown(studentList, studentIndex); 
            //studentList[studentIndex].PrintAge(studentList, studentIndex);
            Console.ReadKey();

        }

        
    }
}
