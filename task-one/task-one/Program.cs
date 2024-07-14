namespace task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printString.printInputString();

            Variables var1 = new Variables();
            var1.printVars();

            CarArray carNames = new CarArray(new string[] { "BMW", "Audi", "Ford" });
            carNames.printCars();

            Console.WriteLine("enter your info");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string year = Console.ReadLine();
            FullName f1 = new FullName(firstName, lastName, year);
            f1.printUserInfo();


            int[] elements = addElement();
            UserArray arr1 = new UserArray(elements);
            arr1.printArray();
            arr1.sumArray();

            
        }
        public static int[] addElement()
        {
            Console.WriteLine("enter 10 numbers");
            int[] elements = new int[10];
            for (int i = 0; i < 10; i++)
            {
               elements[i]= int.Parse(Console.ReadLine());
            }
            return elements;
        }
    }
}
