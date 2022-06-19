﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    class MES : EmergencyService
    {
        public MES(Action<string> Notification, float defaultX, float defaultY, List<Driver> drivers, object driversLocker)
            : base(Notification, defaultX, defaultY, drivers, driversLocker)
        {
            for (int i = 0; i < Emergency.AllEmergency.Length; i++)
                if (Emergency.AllEmergency[i].Contains("глох"))
                    listOfCrash.Add(i);
        }
    }
}
