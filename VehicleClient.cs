using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VehicleClient
    {
        IBike bike;
        IScooter scooter;
        ICar car;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
            car = factory.GetCar(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }

        public string GetCar()
        {
            return car.Name();
        }
    }
}
