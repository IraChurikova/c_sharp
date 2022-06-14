using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб4_библиотекаКлассов
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
