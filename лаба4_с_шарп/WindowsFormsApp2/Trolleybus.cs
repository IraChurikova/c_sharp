﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

        public abstract class Trolleybus
    {
        public int NumberOfTrolleybus { get; set; }
        public int NumberOfPassenger { get; set; }
        public abstract string getSound();
       // public int CountOfGasoline { get; set; }

    }
}
