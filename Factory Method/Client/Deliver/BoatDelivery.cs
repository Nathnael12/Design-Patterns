using Factory_Method.Client.Transport_Type;
using Factory_Method.Factory;

namespace Factory_Method.Client.Deliver
{
    internal class BoatDelivery : Transport
    {
        public override IDelivery CreateTransportMethod()
        {
            return new BoatType();
        }
    }
}
