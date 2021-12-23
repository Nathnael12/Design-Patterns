using Abstract_Factory.Abstract_Factory;
using Abstract_Factory.Client.Flav1;
using Abstract_Factory.Client.Flav2;
using System;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFurniture factory;
            Console.WriteLine("Flavor 1 & 2 Chair");
            factory = new Flav1Factory();
            Chair flav1=factory.CreateChair();
            flav1.Show(flav1.Legs());

            factory = new Flav2Factory();
            Chair flav2=factory.CreateChair();
            flav2.Show(flav2.Legs());
            
            Console.WriteLine("Flavor 1 & 2 Sofa");
            factory = new Flav1Factory();
            Sofa flav1Sofa=factory.CreateSofa();
            flav1Sofa.Show(flav1Sofa.Seats());

            factory = new Flav2Factory();
            Sofa flav2Sofa = factory.CreateSofa();
            flav2Sofa.Show(flav2Sofa.Seats());

            Console.ReadKey();
        }
    }
}
