using Factory_Method.Client.Transport_Type;
using Factory_Method.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Client.Deliver
{
    internal class TaxiDelivery : Transport
    {
        public override IDelivery CreateTransportMethod()
        {
            return new TaxiType();
        }
    }
}
