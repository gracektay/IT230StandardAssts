using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tay_grace_mod8_db_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numOfClasses = 7;

            Course[] courses = new Course[numOfClasses]; 
            string[] courseNames = { "IT 145", "IT 200", "IT 201", "IT 270", "IT 315", "IT 328", "IT 330" };

            for (int i = 0 ; i < numOfClasses; i++)
            {
                courses[i] = new Course( courseNames[i] );
            };
            
            Console.WriteLine("Grace Tay's Copy");
            Console.WriteLine("List of courses:");

            for (int i = 0; i < numOfClasses; i++)
            {
                Console.WriteLine(courses[i].getName());
            }
        }
    }
    class Course
    {
        private string name = "";
        public Course(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}
