using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Driver : TransportService
    {
        public bool isBreak { get; internal set; }
        public int EmergencyIndex { get; internal set; }

        public Driver(Action<string> Notification, float defaultX, float defaultY)
            : base(Notification, defaultX, defaultY)
        {

        }

        public bool WaitHeal { get; internal set; }

        public void RandomBreak(Random random)
        {   
            if (random.Next(0, 10) < 3)
            {
                EmergencyIndex = random.Next(0, Emergency.AllEmergency.Length);
                isBreak = true;
                WaitHeal = false;
            }
        }
        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                ToX = defaultX;
                ToY = defaultY;
            }
        }
    }
}
