using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumsTelefons
{
    public class Phone
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Size { get; set; }

        public void Call()
        {
            Console.WriteLine($"With {Brand} {Model} you can make a calls");
        }

        public void Sms()
        {
            Console.WriteLine("and also sent sms");
        }
    }
}
