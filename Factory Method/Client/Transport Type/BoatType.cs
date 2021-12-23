using Factory_Method.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Client.Transport_Type
{
    internal class BoatType : IDelivery
    {
        public string Deliver()
        {
            return "I am boat Delivery";
        }
    }
}
