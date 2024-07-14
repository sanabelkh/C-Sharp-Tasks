using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_five
{
    internal class MClass
    {
        public static void print()
        {
            Console.WriteLine("MyClass class has initialized!");

        }
        public static void printHelloText(string name)
        {
            Console.WriteLine($"Hello All, I am {name}");

        }
        public static int[] sortArr(int[] arr)
        {
            Array.Sort(arr);
            return arr;
            
        }
    }
}
