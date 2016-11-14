using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaySwitchStatementDiscussion
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool conversionSuccess;
            int convertedNumber;
            int courseNumber = 0;

            //Get string from user
            Console.WriteLine("Grace Tay's version");
            Console.Write("Enter a number: ");
            userInput = Console.ReadLine();

            //Convert string to int
            conversionSuccess = Int32.TryParse(userInput, out convertedNumber);
            while(conversionSuccess != true)
            {
                Console.WriteLine("This program only accepts integers. Try 1, 2, 3...");
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine();
                conversionSuccess = Int32.TryParse(userInput, out convertedNumber);
            }

            //Use switch statement to map a number to its corresponding course code
            switch(convertedNumber)
            {
                case 1 :
                    courseNumber = 145;
                    break;
                case 2 :
                    courseNumber = 200;
                    break;
                case 3 :
                    courseNumber = 201;
                    break;
                case 4 :
                    courseNumber = 270;
                    break;
                case 5 :
                    courseNumber = 315;
                    break;
                case 6 :
                    courseNumber = 328;
                    break;
                case 7:
                    courseNumber = 330;
                    break;
                default:
                    courseNumber = 0;
                    break;
            }

            //Output the course to the user, or tell them it's unavailable
            if (courseNumber==0)
            {
                Console.WriteLine("Sorry, that course is unavailable!");
            }
            else
            {
                Console.Write("Your choice of " + convertedNumber);
                Console.WriteLine(" is this course IT: " + courseNumber);
            }
        }
    }
}
