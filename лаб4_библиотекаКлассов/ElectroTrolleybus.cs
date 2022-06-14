using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб4_библиотекаКлассов
{
    public class ElectroTrolleybus:Trolleybus
    {
        public override string getSound()
        {
            return "Electrotrolleybus goes";
        }
        public string getTypeOfTrolleybus()
        {
            return "Electrotrolleybus";
        }
        public string ColorElectroTrolleybus()
        {
            return "blue";
        }
        public string addPassangers(int a)
        {
            NumberOfPassenger += a;
            return Convert.ToString(NumberOfPassenger);
        }
    }
}
