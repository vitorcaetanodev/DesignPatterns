// DecoratorPattern/Program.cs
using System;

namespace DecoratorPattern
{
    // Component
    public abstract class Car
    {
        public abstract void Assemble();
    }

    // ConcreteComponent
    public class BasicCar : Car
    {
        public override void Assemble() => Console.WriteLine("Basic car assembled.");
    }

    // Decorator
    public class CarDecorator : Car
    {
        private readonly Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override void Assemble() => _car.Assemble();
    }

    // ConcreteDecorator
    public class SportsCar : CarDecorator
    {
        public SportsCar(Car car) : base(car) {}

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding features of Sports Car.");
        }
    }

    class Program
    {
        static void Main()
        {
            Car sportsCar = new SportsCar(new BasicCar());
            sportsCar.Assemble();
        }
    }
}
