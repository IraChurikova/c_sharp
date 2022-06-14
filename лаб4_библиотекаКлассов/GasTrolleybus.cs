using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб4_библиотекаКлассов
{
    public class GasTrolleybus : Trolleybus
    {
        public override string getSound()
        {
            return "Gas trolleybus goes";
        }
        public string getTypeOfTrolleybus1()
        {
            return "GasTrolleybus";
        }
        public string ColorGasTrolleybus()
        {
            return "grey";
        }

    }
}
