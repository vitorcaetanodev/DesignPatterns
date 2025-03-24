// AdapterPattern/Program.cs
using System;

namespace AdapterPattern
{
    // Target Interface
    public interface ITarget
    {
        void Request();
    }

    // Adaptee
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest in Adaptee.");
        }
    }

    // Adapter
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    class Program
    {
        static void Main()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            target.Request();
        }
    }
}
