// FlyweightPattern/Program.cs
using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    // Flyweight
    public class Car
    {
        private readonly string _model;
        private readonly string _color;

        public Car(string model, string color)
        {
            _model = model;
            _color = color;
        }

        public void Display()
        {
            Console.WriteLine($"Car Model: {_model}, Color: {_color}");
        }
    }

    // FlyweightFactory
    public class CarFactory
    {
        private readonly Dictionary<string, Car> _cars = new Dictionary<string, Car>();

        public Car GetCar(string model, string color)
        {
            string key = model + color;

            if (!_cars.ContainsKey(key))
            {
                _cars[key] = new Car(model, color);
            }

            return _cars[key];
        }
    }

    class Program
    {
        static void Main()
        {
            var factory = new CarFactory();

            var car1 = factory.GetCar("Model A", "Red");
            car1.Display();

            var car2 = factory.GetCar("Model A", "Red");
            car2.Display();  // Should be the same object as car1
        }
    }
}
