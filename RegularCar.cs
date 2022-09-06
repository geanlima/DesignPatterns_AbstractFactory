using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RegularCar : ICar
    {
        public string Name()
        {
            return "Regular Car- Name";
        }
    }
}
