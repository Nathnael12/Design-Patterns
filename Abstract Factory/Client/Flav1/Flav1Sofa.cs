using Abstract_Factory.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Client.Flav1
{
    internal class Flav1Sofa : Sofa
    {
        public override string Seats()
        {
            return "4 Seats";
        }
    }
}
