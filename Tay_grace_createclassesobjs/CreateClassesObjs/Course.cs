using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassesObjs
{
    class Course

    {
        private string courseName; //REQ1 Private string field to hold name of course

        public Course() //default constructor
        {
            courseName = "Default course name";
        }

        public Course(string initialCourseName) //overloaded constructor
        {
            courseName = initialCourseName;
        }

        public void SetName(string a) //REQ2 set name field to string. Because of the book's suggestion, I changed this public function to be capitalized
        {
            courseName = a;
        }
        
        public string GetName() //REQ3 Retrieve name field
        {
            return courseName;
        }

        public override string ToString() //REQ4 Returns name field by calling GetName()
        {
            return GetName();
        }
    }
}
