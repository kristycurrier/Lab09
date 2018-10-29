using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    // James - Sweet, not only are you using a seperate class but you are also storing that class in a seperate file. 
    class Student
    {
        private string _studentNumber;
        private string _firstName;
        private string _lastName;
        private string _homeTown;
        private string _age;
        private string _color;

        public Student(string studentNumber, string firstName, string lastName, string homeTown, string age, string color)
        {
            _studentNumber = studentNumber;
            _firstName = firstName;
            _lastName = lastName;
            _homeTown = homeTown;
            _age = age;
            _color = color;
        }

        public static int GetStudentNumber(int lengthOfList)
        {
            // James - I like that this is being seperated into a seperate method, though I don't know if the Student 
            // class really cares about this information.
            Console.WriteLine($"Welcome to our C# class. Which student would you " +
                 $"like to learn about? (enter a number 1- {lengthOfList}): ");
            string studentNumberInput = Console.ReadLine();
            bool realNumber = int.TryParse(studentNumberInput, out int studentNumber);

            // James - nice way of validating, though I would maybe seperate all of your validation into a 
            // seperate Validation class instead.
            while (realNumber == false || studentNumber<1 || studentNumber > lengthOfList)
            {
                Console.WriteLine($"Please enter a number between 1 and {lengthOfList}: ");
                studentNumberInput = Console.ReadLine();
                realNumber = int.TryParse(studentNumberInput, out studentNumber);
            }
            return studentNumber;
        }

        public void PrintIntroQuestion(List<Student> studentData, int studentIndex)
        {   
            // James - Same as the last method, I like that this is in it's own method, but I would maybe
            // put this in a differnet class. 
            string studentNumber = studentData[studentIndex]._studentNumber;
            string firstName = studentData[studentIndex]._firstName;
            string lastName = studentData[studentIndex]._lastName;
            Console.WriteLine($"Student {studentNumber} is {firstName} {lastName}. What would you like to know about {firstName}? (enter \"hometown\", \"age\" or \"color\"): ");
        }

        public static void PrintExtraInfo(string info, List<Student> studentData, int studentIndex)
        {
                // James - yep good stuff, maybe in a different class though.
                bool validInput = false;
                while (validInput == false)
                {
                    if (info.Equals("hometown", StringComparison.OrdinalIgnoreCase))
                    {
                        Student.PrintHomeTown(studentData, studentIndex);
                        validInput = true;
                        break;
                    }
                    else if (info.Equals("age", StringComparison.OrdinalIgnoreCase))
                    {
                        Student.PrintAge(studentData, studentIndex);
                        validInput = true;
                        break;
                    }
                else if (info.Equals("color", StringComparison.OrdinalIgnoreCase))
                {
                    Student.PrintColor(studentData, studentIndex);
                    validInput = true;
                    break;
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

        public static void PrintColor(List<Student> studentData, int studentIndex)
        {
            string firstName = studentData[studentIndex]._firstName;
            string color = studentData[studentIndex]._color;
            Console.WriteLine($"{firstName}'s favorite color is {color}. Would you like to know more? (y/n)");
        }

        public static bool ContinueTheProgram(string yesNoAnswer)
        {
            bool repeatTheProgram = true;
            bool validInput = false;
            do
            {
               // yesNoAnswer = Console.ReadLine();
                if (yesNoAnswer.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    repeatTheProgram = true;
                    validInput = true;
                }
                else if (yesNoAnswer.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    repeatTheProgram = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("That isn't a valid input, type y for yes or n for no.");
                    validInput = false;
                }
            } while (validInput == false);

            return repeatTheProgram;
            
        }

        public static List<Student> GetDefaults()
        {
            // James - pretty cool method, although I may put it in a differnet class altogether but I'm not sure if this really relates 
            // to a single student, but I still like this method, cool stuff.  I would also rename it to like 
            // GetDefaultStudents just to make it more clear what this is doing.
            List<Student> studentData = new List<Student>();
            studentData.Add(new Student("1", "Bob", "Smith", "Detroit, MI", "20", "blue"));
            studentData.Add(new Student("2", "Cody", "Jenkins", "Royal Oak, MI", "28", "red"));
            studentData.Add(new Student("3", "Josh", "O'Connor", "Berkley, MI", "18", "yellow"));
            studentData.Add(new Student("4", "Kara", "Gheldof", "Royal Oak, MI", "32", "green"));
            studentData.Add(new Student("5", "Brandon", "Quinn", "Detroit, MI", "40", "purple"));
            studentData.Add(new Student("6", "Raven", "Caswell", "Chicago, IL", "22", "red"));
            studentData.Add(new Student("7", "Les", "Potter", "Detroit, MI", "25", "green"));
            studentData.Add(new Student("8", "Jennifer", "Williams", "Troy, MI", "35", "teal"));
            studentData.Add(new Student("9", "Jeff", "Stevens", "Grosse Point, MI", "40", "pink"));
            studentData.Add(new Student("10", "Zach", "Hobart", "Houston, TX", "35", "red"));
            studentData.Add(new Student("11", "Adam", "Reeds", "Detroit, MI", "25", "purple"));
            studentData.Add(new Student("12", "Kelsey", "Taylor", "Oak Park, MI", "32", "blue"));
            studentData.Add(new Student("13", "Colleen", "Ewald", "Redford, MI", "28", "green"));
            studentData.Add(new Student("14", "Joseph", "Harrison", "Troy, MI", "21", "pink"));
            studentData.Add(new Student("15", "William", "McKay", "Hazel Park, MI", "20", "blue"));
            studentData.Add(new Student("16", "Charlotte", "Left", "Lake Orion, MI", "39", "teal"));
            studentData.Add(new Student("17", "Marnie", "Fargel", "Toledo, OH", "45", "red"));
            studentData.Add(new Student("18", "Liam", "Piper", "Holland, MI", "42", "yellow"));
            studentData.Add(new Student("19", "Craig", "Jones", "Farmington Hills, MI", "33", "green"));
            studentData.Add(new Student("20", "John", "Smith", "Novi, MI", "32", "teal"));
            return studentData;
        }

    }
}
