using System.Globalization;
using System.Numerics;

namespace task_five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateString = "12-08-2004";
            convertDate(dateString);
            DateTime startDate = new DateTime(2024, 6, 25);
            DateTime endDate = new DateTime(2029, 6, 30);
            diffTwoDates(startDate, endDate);
            MClass.print();
            MClass.printHelloText("majed");
            Console.WriteLine(factorial(5));
            int[] array = { 5, 2, 8, 3, 1 };
            int[] sortedArray = MClass.sortArr(array);

            Console.WriteLine("Sorted array: " + string.Join(", ", sortedArray));
        }

        static int factorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("wrong input");
                return (-1);
            }
            if (n == 1) {
                return 1;
            }
            return n * factorial(n - 1);
        }
        static void diffTwoDates(DateTime d1, DateTime d2)
        {
            if (d1 > d2)
            {
                Console.WriteLine(d1 - d2);
            }
            else
            {
                Console.WriteLine(d2 - d1);
            }
        }
        static void convertDate(string dateString) {

            string format = "dd-MM-yyyy";

            DateTime date;
            bool isValidDate = DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

            if (isValidDate)
            {
                Console.WriteLine("Converted Date: " + date.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }
    }
}
