namespace task_nine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota Camry", "Sedan", "2023", "Silver", 25000.50m, "12345", 2023);
            Console.WriteLine(car1.CarInfo());

            Car1 myCar = new Car1("Toyota", "Camry", 2023, 4);

            myCar.DisplayInfo();
        }
    }
}
