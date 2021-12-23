using Abstract_Factory.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Client.Flav2
{
    internal class Flav2Factory : IFurniture
    {
        public Chair CreateChair()
        {
            return new Flav2Chair();
        }

        public Sofa CreateSofa()
        {
            return new Flav2Sofa();
        }
    }
}
