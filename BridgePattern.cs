// BridgePattern/Program.cs
using System;

namespace BridgePattern
{
    // Abstraction
    public abstract class RemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public abstract void PowerOn();
        public abstract void PowerOff();
    }

    // RefinedAbstraction
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) {}

        public override void PowerOn() => _device.TurnOn();
        public override void PowerOff() => _device.TurnOff();

        public void Mute() => _device.Mute();
    }

    // Implementor
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void Mute();
    }

    // ConcreteImplementor
    public class Television : IDevice
    {
        public void TurnOn() => Console.WriteLine("TV is now ON.");
        public void TurnOff() => Console.WriteLine("TV is now OFF.");
        public void Mute() => Console.WriteLine("TV is muted.");
    }

    class Program
    {
        static void Main()
        {
            IDevice tv = new Television();
            RemoteControl remote = new AdvancedRemoteControl(tv);
            remote.PowerOn();
            remote.PowerOff();
        }
    }
}
