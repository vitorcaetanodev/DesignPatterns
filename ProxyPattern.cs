// ProxyPattern/Program.cs
using System;

namespace ProxyPattern
{
    // Subject
    public interface IRealSubject
    {
        void Request();
    }

    // RealSubject
    public class RealSubject : IRealSubject
    {
        public void Request() => Console.WriteLine("Request processed by RealSubject.");
    }

    // Proxy
    public class Proxy : IRealSubject
    {
        private readonly RealSubject _realSubject;

        public Proxy()
        {
            _realSubject = new RealSubject();
        }

        public void Request()
        {
            Console.WriteLine("Proxy: Logging request.");
            _realSubject.Request();
        }
    }

    class Program
    {
        static void Main()
        {
            IRealSubject proxy = new Proxy();
            proxy.Request();
        }
    }
}
