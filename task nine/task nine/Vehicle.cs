using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_nine
{
    internal class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }

    internal class Car1 : Vehicle
    {
        public Car1(string brand, string model, int year, int doors)
            : base(brand, model, year)
        {
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Car Details:\nBrand: {Brand}, Model: {Model}, Year: {Year}");
        }
        

    }
}
