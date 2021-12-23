using Factory_Method.Client.Deliver;
using Factory_Method.Factory;
using System;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport boat = new BoatDelivery();
            Transport taxi = new TaxiDelivery();
            boat.Transporter(boat.CreateTransportMethod().Deliver());
            taxi.Transporter(taxi.CreateTransportMethod().Deliver());
            Console.ReadKey();
        }
    }
}
