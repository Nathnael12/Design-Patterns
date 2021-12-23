using Singleton.Singlton;
using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We create two instances of SomeConfiguration class
            //They should use one same instance 
            SomeConfiguration configuration = SomeConfiguration.Config();
            SomeConfiguration configuration2 = SomeConfiguration.Config();

            //Changing the value of 'configuration2' object will also apply to the 'configuration' object since they are one same instance
            configuration2.setUser("another user");

            //We should get the new 'user' value even if we are logging 'user' from the unchanged object
            Console.WriteLine(configuration.getHost());
            Console.WriteLine(configuration.getUser());

            //Prevent our Console from closing automatically
            Console.Write("Press any key to exit . . . ");
            Console.ReadKey();
        }
    }
}
