/*
Grace Tay
IT-230 Software Development with C#.NET
11/14/2016
4-2 Final Project Part I, Milestone Two Coding Activity: Debug & Fix If Statements (DebugFixIFStmt)

This assignment focuses on debugging an if else based program. There were five errors: an extra '=', a missing '=', two inaccurate conditions if the if and last else if,
and a randomly placed variable. Now, the program successfully lists choices.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixIFStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

            System.Console.WriteLine("Grace Tay's Copy");

            firstChoice = 0; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 7;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
        }


        void WriteCurrentChoices(int firstChoice, int secondChoice, int thirdChoice)
        {
            if (firstChoice == 0) //Error 5: I changed the if (secondChoice ==0) to (firstChoice ==0), explained in document
                Console.WriteLine("Choices are: {0}, {1}, {2} => There are no choices yet", firstChoice, secondChoice, thirdChoice);
            else if (secondChoice == 0) //Error 2: added '=' since we need an equality operator
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}", firstChoice, secondChoice, thirdChoice);  //Error 4: Removed the improperly placed first choice
            else if (thirdChoice == 0) //Error 1: Deleted the extra equal sign
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice);
            else if (thirdChoice == 7) //Error 3: changed 0 to 7 to match the fourth block of code  above, where third choice equals 7
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}, {2}",
                    firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice, thirdChoice);
        }
    }
}

