using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{
    internal class FullName
    {
        public string fName;
        public string lName;
        public string yearOfBirth;

        public FullName(string fname, string lName,string yearOfBirth)
        {
            this.fName = fname;
            this.lName = lName;
            this.yearOfBirth = yearOfBirth;
        }


        public void printUserInfo()
        {
            Console.WriteLine(fName+" "+ lName + " " + yearOfBirth);
        }
    }
}
