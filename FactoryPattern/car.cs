using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public string color { get; set; }
        public bool isDriveable { get; set; }

        public void Drive()
        {
            Console.WriteLine("Sorry Cant talk im driving");
        }
    }
}
