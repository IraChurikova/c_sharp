using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public abstract class EmergencyService : TransportService, IEmergencyService
    {
        private readonly List<Driver> Drivers;
        private readonly object DriversLocker;
        Driver breakDriver;

        public EmergencyService(Action<string> Notification, float defaultX, float defaultY, List<Driver> drivers, object DriversLocker)
            : base(Notification, defaultX, defaultY)
        {
            listOfCrash = new List<int>();

            this.Drivers = drivers;
            this.DriversLocker = DriversLocker;
        }
        public List<int> listOfCrash { get; }
        void Heal()
        {
            if (IsCome())
            {
                Notification($"Аварийная служба {nameOfObject} {numberOfObject} решает проблему троллейбуса " +
                        $"{breakDriver.nameOfObject} {breakDriver.numberOfObject}");

                Task.Delay(5 * 1000).Wait();

                breakDriver.isBreak = false;
                breakDriver.IsLocked = false;

                Notification($"Троллейбус {breakDriver.nameOfObject} {breakDriver.numberOfObject} снова в действие");
                DoSomething = null;
                IsLocked = false;
                ToX = defaultX;
                ToY = defaultY;
            }
        }
        protected override void CheckEvents()
        {
            if (IsLocked)
                return;

            lock(DriversLocker)
            {
                breakDriver = Drivers
                    .FirstOrDefault(Driver => Driver.isBreak &&
                    listOfCrash.Contains(Driver.EmergencyIndex)
                    && !Driver.WaitHeal);

                if (breakDriver != null)
                {
                    breakDriver.WaitHeal = true;
                    ToX = breakDriver.X;
                    ToY = breakDriver.Y;

                    IsLocked = true;
                    DoSomething = Heal;

                    Notification($"Аварийная служба {nameOfObject} {numberOfObject} поехала решать проблему " +
                        $"{breakDriver.nameOfObject} {breakDriver.numberOfObject}");
                }
            }
        }
    }
}
