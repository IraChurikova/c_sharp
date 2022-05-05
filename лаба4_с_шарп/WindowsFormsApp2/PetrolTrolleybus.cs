using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class PetrolTrolleybus:Trolleybus
    {
        public override string getSound()
        {
            return "Petrol trolleybus goes";
        }
        public string getTypeOfTrolleybus2()
        {
            return "PetrolTrolleybus";
        }
        public string ColorPetrolTrolleybus()
        {
            return "green";
        }
    }
}
