using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Factory
{
    internal abstract class Transport
    {
        public abstract IDelivery CreateTransportMethod();

        public void Transporter(string inputData)
        {
            Console.WriteLine(inputData);
        }
    }
}
