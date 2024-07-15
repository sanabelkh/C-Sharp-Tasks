using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace task_six
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1};
            string[] strs = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
            int[] nums1 = [44, 5, 4, 3, 2, 10];
            List<int> result =evenNumberEvenIndex(nums);
            List<string> resultStr = evenIndexOddLength(strs);
            double[] res = powerElementIndex(nums1);
            foreach (double i in res)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(muti2(4, 5));
            int[] nums2 = [1, 2, 3, 8, 9];
            Console.WriteLine(aveArray(nums2));
        }
        static int minToSec(int min) 
        {
            return min * 60;
        }
        static int addOne(int num)
        {
            return num+1;
        }
        static int returnFirstElements(int[] nums)
        {
            return nums[0];
        }
        static int triangleArea(int baseTri,int height )
        {
            return (baseTri * height) / 2;
        }
        static List<int> evenNumberEvenIndex(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]%2 == 0 && i %2==0)
                {
                    result.Add(nums[i]);
                }
            }
            return result;
        }
        static List<string> evenIndexOddLength(string[] nums)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].Length % 2 != 0 && i % 2 == 0)
                {
                    result.Add(nums[i]);
                }
            }
            return result;
        }
        static double[] powerElementIndex(int[] numbers)
        {
            double[] powerOfNums = numbers.Select(num => (double)num).ToArray();
            for (int i = 0;i < powerOfNums.Length; i++)
            {
                powerOfNums[i]=Math.Pow(powerOfNums[i],i);
            }
            return powerOfNums;
        }

        static int multiplication2(int n, int x) 
        {
            int total = 0;
            for (int i = 0; i < x; i++)
            {
                total+= n;
            }
            return total;   
        }
        
        static int muti2(int n, int x)
        {
            int total = 1;
            for (int i = n; i <= x; i++)
            {

                total *= i;
            }
            return total;
        }
        static double aveArray(int[] nums)
        {
            double sum = 0;
            foreach(int x in nums)
            {
                sum += x;
            }
            return sum/nums.Length;
        }
    }
}
