using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grace Tay's version");
            (new Program()).run();
        }


        void run()
        {
            int choice = 0;

            WritePrompt(); //Fixed Error 1 in function declarations
            choice = ReadChoice();
            WriteChoice(choice);

        }

        void WritePrompt() //Error 1: Improperly capitalized function declaration.
        {
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }
     
        int ReadChoice()
        {
            string s = "";
            bool success;
            int result;

            s = Console.ReadLine();

            //Attempting TryParse to check for int (Still classified under error 4)
            success = Int32.TryParse(s, out result);
            while(success != true) 
            {
                Console.WriteLine("That is invalid. Please type in the numeric value inside []");
                Console.Write("Enter your choice : ");
                s = Console.ReadLine();
                success = Int32.TryParse(s, out result);
            }

            return result;
            //return Convert.ToInt32(s); //Error 4: This function must return an int, so we have to conver the string 's' to and int.
        }

        void WriteChoice(int choice) //Error 2: Must specify data type, which is an int since the choice is always whole.
        {
            Console.WriteLine("Your choice is {0}", choice); //Error 3: Choice changed to choice to match the casing of the parameter, which is a lowercase variable.
        }

    }
}
