using Abstract_Factory.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Client.Flav2
{
    internal class Flav2Chair : Chair
    {
        public override string Legs()
        {
            return "4 Legs";
        }
    }
}
