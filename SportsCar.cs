using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SportsCar : ICar
    {
        public string Name()
        {
            return "Sports Car - Name";
        }
    }
}
