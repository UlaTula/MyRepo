using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumsCar
{
    public class Car
    {
        public string Brand { get; set; }

        public string RegNumber { get; set; }

        public void BeepBeep()
        {
            Console.WriteLine($"Car brand {Brand} and registration number {RegNumber} says beep beep");
        }
    }
}
