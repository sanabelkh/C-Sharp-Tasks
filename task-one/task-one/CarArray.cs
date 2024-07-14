using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{
    internal class CarArray
    {
        private string[] cars;

        public CarArray(string[] array) {
        cars = array;
        
        }
        public void printCars()
        {
            Console.WriteLine(cars.Length);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
