// CompositePattern/Program.cs
using System;
using System.Collections.Generic;

namespace CompositePattern
{
    // Component
    public abstract class Component
    {
        public abstract void Display();
    }

    // Leaf
    public class Leaf : Component
    {
        public override void Display() => Console.WriteLine("Leaf item.");
    }

    // Composite
    public class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public void Add(Component component) => _children.Add(component);

        public void Remove(Component component) => _children.Remove(component);

        public override void Display()
        {
            Console.WriteLine("Composite item.");
            foreach (var child in _children)
            {
                child.Display();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var leaf1 = new Leaf();
            var leaf2 = new Leaf();

            var composite = new Composite();
            composite.Add(leaf1);
            composite.Add(leaf2);

            composite.Display();
        }
    }
}
