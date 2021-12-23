using Abstract_Factory.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Client.Flav2
{
    internal class Flav2Sofa : Sofa
    {
        public override string Seats()
        {
            return "3 Seats";
        }
    }
}
