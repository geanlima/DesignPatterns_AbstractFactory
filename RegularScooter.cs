﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
