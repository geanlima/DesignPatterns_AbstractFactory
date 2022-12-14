using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory honda = new HondaFactory();

            VehicleClient hondaclient = new VehicleClient(honda, "Regular");
            Console.WriteLine("******* Honda **********");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            hondaclient = new VehicleClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            hondaclient = new VehicleClient(honda, "Regular");
            Console.WriteLine(hondaclient.GetCar());

            IVehicleFactory suzuki = new SuzukiFactory();
            VehicleClient suzukiClient = new VehicleClient(suzuki, "Regular");

            Console.WriteLine("******* Suzuki **********");
            Console.WriteLine(suzukiClient.GetBikeName());
            Console.WriteLine(suzukiClient.GetScooterName());

            suzukiClient = new VehicleClient(suzuki, "Sports");
            Console.WriteLine(suzukiClient.GetBikeName());
            Console.WriteLine(suzukiClient.GetScooterName());

            suzukiClient = new VehicleClient(honda, "Regular");
            Console.WriteLine(suzukiClient.GetCar());

            Console.ReadKey();
        }
    }
}
