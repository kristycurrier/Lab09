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
            Console.WriteLine("Welcome to our C# class. Which student would you " +
                "like to learn about? (enter a number 1-20): ");
            string studentNumberInput = Console.ReadLine();
            bool realNumber = int.TryParse(studentNumberInput, out int studentNumber);

            int studentIndex = studentNumber - 1;
            var studentList = GetDefaults();

            //Console.WriteLine($"Student {studentNumberInput} is {studentList[studentIndex].firstName}. What would you like to know about ")

            studentList[studentIndex].PrintHomeTown(studentList, studentIndex);
            studentList[studentIndex].PrintAge(studentList, studentIndex);
            Console.ReadKey();

        }

        private static List<Student> GetDefaults()
        {

            List<Student> studentData = new List<Student>();
            studentData.Add(new Student ("1", "Bob", "Smith", "Detroit, MI", "20" ));
            studentData.Add(new Student ( "2", "Cody", "Jenkins", "Royal Oak, MI", "28" ));
            studentData.Add(new Student ("3", "Josh", "O'Connor","Berkley, MI", "18" ));
            studentData.Add(new Student ( "4", "Kara" , "Gheldof","Royal Oak, MI", "32" ));
            studentData.Add(new Student ( "5", "Brandon", "Quinn", "Detroit, MI", "40" ));
            studentData.Add(new Student ( "6", "Raven", "Caswell", "Chicago, IL", "22" ));
            studentData.Add(new Student ( "7", "Les", "Potter", "Detroit, MI", "25" ));
            studentData.Add(new Student ( "8", "Jennifer", "Williams", "Troy, MI", "35" ));
            studentData.Add(new Student ( "9", "Jeff", "Stevens", "Grosse Point, MI", "40" ));
            studentData.Add(new Student ( "10", "Zach", "Hobart", "Houston, TX", "35" ));
            studentData.Add(new Student ( "11", "Adam", "Reeds", "Detroit, MI", "25" ));
            studentData.Add(new Student ( "12", "Kelsey", "Taylor", "Oak Park, MI", "32" ));
            studentData.Add(new Student ( "13", "Colleen", "Ewald", "Redford, MI", "28" ));
            studentData.Add(new Student ( "14", "Joseph", "Harrison", "Troy, MI", "21" ));
            studentData.Add(new Student ( "15", "William", "McKay", "Hazel Park, MI", "20" ));
            studentData.Add(new Student ( "16", "Charlotte", "Left", "Lake Orion, MI", "39" ));
            studentData.Add(new Student ( "17", "Marnie", "Fargel", "Toledo, OH", "45" ));
            studentData.Add(new Student ( "18", "Liam", "Piper", "Holland, MI", "42" ));
            studentData.Add(new Student ( "19", "Craig", "Jones", "Farmington Hills, MI", "33" ));
            studentData.Add(new Student ( "20", "John", "Smith", "Novi, MI", "32" ));
            return studentData;

            





        }
    }
}
