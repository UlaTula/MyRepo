using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumsPrece
{
    public class Prece
    {

        public Prece(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }
        public double Lenght { get; }
        public double Width { get; }
        public double Height { get; }
        public string Weight { get; set; }
    }


}

