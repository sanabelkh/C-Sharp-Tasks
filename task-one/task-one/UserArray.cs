using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{
    internal class UserArray
    {
        public int[] ints;
        public UserArray(int[] ints)
        {
            this.ints = ints;

        }
        public void printArray()
        {
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }
        }
        public void sumArray()
        {
            int sum  = 0;
            foreach(var i in ints)
            {
                sum+= i;
            }
            Console.WriteLine(sum);
        }
    }
}
