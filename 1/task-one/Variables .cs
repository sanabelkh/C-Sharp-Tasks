using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{
    internal class Variables
    {
        public int number = 60;
        public double doubleNumber = 0.896;
        public string string1 = "how are you?";
        public char character = 'm';
        public bool boolean = false;
        public const int constNumber =55 ;

        public void printVars() {
            Console.WriteLine(constNumber);
            Console.WriteLine(number);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(character);
            Console.WriteLine(boolean);
            Console.WriteLine(string1);



        }

    }
}
