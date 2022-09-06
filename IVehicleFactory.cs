using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IVehicleFactory
    {
        IBike GetBike(string bike);
        IScooter GetScooter(string scooter);
        ICar GetCar(string car);
    }
}
