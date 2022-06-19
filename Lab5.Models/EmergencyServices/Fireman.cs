using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    class Fireman : EmergencyService
    {
        public Fireman(Action<string> Notification, float defaultX, float defaultY, List<Driver> spotsmans, object driversLocker) : base(Notification, defaultX, defaultY, spotsmans, driversLocker)
        {
            for (int i = 0; i < Emergency.AllEmergency.Length; i++)
                if (Emergency.AllEmergency[i].Contains("гор"))
                    listOfCrash.Add(i);
        }
    }
}
