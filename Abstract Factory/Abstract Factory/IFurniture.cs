using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Abstract_Factory
{
    internal interface IFurniture
    {
        public Chair CreateChair();
        public Sofa CreateSofa();
    }
}
