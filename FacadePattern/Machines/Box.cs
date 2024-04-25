using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Box
    {
        private Random _random = new Random();
        internal int GetInternalTemperature()
        {
            return _random.Next(10, 80);
        }

        internal int GetExternalTemperature()
        {
            return _random.Next(10, 80);
        }
    }
}
