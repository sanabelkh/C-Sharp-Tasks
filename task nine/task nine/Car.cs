using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_nine
{
    internal class Car
    {
        private string _name;
        private string _type;
        private string _model;
        private string _color;
        private decimal _price;
        private string _palletNo;
        private int _year;
        private bool _isEngineRunning;

        public Car(string name, string type, string model, string color, decimal price, string palletNo, int year)
        {
            _name = name;
            _type = type;
            _model = model;
            _color = color;
            _price = price;
            _palletNo = palletNo;
            _year = year;
            _isEngineRunning = false;

        }
        public void ControlEngine()
        {
            if (_isEngineRunning)
            {
                _isEngineRunning = false;
            }
            else
            {
                _isEngineRunning = true;
            }
        }
        public string CarInfo()
        {
            return $"Car Details:\n" +
                   $"Name: {_name}\n" +
                   $"Type: {_type}\n" +
                   $"Model: {_model}\n" +
                   $"Color: {_color}\n" +
                   $"Price: {_price:C}\n" +
                   $"Pallet Number: {_palletNo}\n" +
                   $"Year: {_year}\n" +
                   $"Engine Status: {_isEngineRunning}\n";
        }

    }
}
