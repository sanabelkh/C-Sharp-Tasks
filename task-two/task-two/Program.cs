namespace task_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            minNumber(8, 98);
            findSignOfTheNumber(9);
            sortThreeNumbers(8, 12, -7);
            maxNum(1,2,3,4,5);
            convertKPHToMPH(15);
            timeInMin(5, 37);
            timeInHours(546);
            fixedStringLength(new string[] { "hello majed", "hello ahmed", "hello ali", "hello sara", "hello mohammed" });
            reverseOddStrings("hello seman posdokf fsdsgf dddd ddsas");
            reverseOddStrings(("One two three four"));
        }

        static void minNumber(int x, int y) {
            if (x < y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }
        }
        static void findSignOfTheNumber(int x)
        {
            if (x < 0)
            {
                Console.WriteLine("-");
            }
            else if(x==0)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        static void sortThreeNumbers(int x, int y, int z)
        {
            int temp;

            if (x > y)
            {
                temp = x;
                x = y;
                y = z;
            }
            if (x > z) 
            {
                temp = x;
                x = z;
                z = temp;
            }
            if(y > z)
            {
                temp = y;
                y = z;
                z = temp;
            }
            Console.WriteLine(x +" "+y +" "+z);
        }
        static void maxNum(int one,int two,int three, int four,int five)
        {

            int max= one;
            if (two > max) 
                max = two;
            if (three > max)
                max = three;
            if (four > max)
                max = four;
            if (five > max)
                max = five;

            Console.WriteLine(max);
            
        }
        static void convertKPHToMPH(double speed)
        {
            const double mile = 1.61;

            double res = speed / mile;
            Console.WriteLine(res);
        }

        static void timeInMin(int hours,int minutes)
        {
            Console.WriteLine(hours*60+minutes);
        }

        static void timeInHours(int minutes)
        {
            Console.WriteLine("hours "+minutes /60 + " minutes " +minutes % 60);
        }

        static void fixedStringLength(String[] strs)
        {
            foreach(String str in strs)
            {
                Console.WriteLine(str.Substring(0,8));
            }
        }

        static void reverseOddStrings(String str)
        {
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] chars = words[i].ToCharArray();
                    Array.Reverse(chars); 
                    words[i] = new string(chars); 
                }

            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }


}
