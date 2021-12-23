using Abstract_Factory.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Client.Flav1
{
    internal class Flav1Factory : IFurniture
    {
        public Chair CreateChair()
        {
            return new Flav1Chair();
        }

        public Sofa CreateSofa()
        {
            return new Flav1Sofa();
        }
    }
}
