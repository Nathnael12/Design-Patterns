
using Factory_Method.Factory;

namespace Factory_Method.Client.Transport_Type
{
    internal class TaxiType : IDelivery
    {
        public string Deliver()
        {
            return "I am Taxi Delivery";
        }
    }
}
