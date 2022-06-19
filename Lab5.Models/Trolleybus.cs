using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5.Models
{
  
    public class Trolleybus : Model
    {
       
        private readonly List<Driver> Drivers;
        private readonly object DriversLocker;
        List<Driver> participatingDrivers;
        string Name { get; }
        int maxParticipatingDriversNumber;

        public Trolleybus(Action<string> Notification, List<Driver> Drivers, object DriversLocker,
            float x, float y, string name, int maxParticipatingDriversNumber = 5)
            : base(Notification)
        {
            this.Drivers = Drivers;
            this.DriversLocker = DriversLocker;
            X = x;
            Y = y;
            participatingDrivers = new List<Driver>();
            Name = name;
            this.maxParticipatingDriversNumber = maxParticipatingDriversNumber;
        }


        bool StartTrolleybus()
        {
            participatingDrivers.Clear();

            lock (DriversLocker)
            {
                int participatingDriversNumber = 0;

                for (int i = 0; i < Drivers.Count && participatingDriversNumber < maxParticipatingDriversNumber; i++)
                {
                    if (!Drivers[i].IsLocked)
                    {
                        Drivers[i].ToX = X;
                        Drivers[i].ToY = Y;

                        Drivers[i].IsLocked = true;
                        participatingDrivers.Add(Drivers[i]);

                        participatingDriversNumber++;
                    }
                }
            }

            return participatingDrivers.Count != 0;
        }

        void WaitAllDrivers()
        {
            bool allDriversGood = false; ;

            while (!allDriversGood)
            {
                Task.Delay(100).Wait();

                lock (DriversLocker)
                {
                    allDriversGood = participatingDrivers.FirstOrDefault(item =>
                    !item.IsCome()) == null;
                }
            }
        }

        void DoTrolleybus()
        {
            Notification($"В рейсе {Name} будет {participatingDrivers.Count} водителя");
            WaitAllDrivers();

            Notification($"Рейс {Name} начинается");
            Notification($"Рейс {Name} в пути");

            Task.Delay(10 * 1000).Wait();
        }

        void PrintWinDriver( Driver Driver)
        {
            Notification($" {Driver.nameOfObject} {Driver.numberOfObject} ставит штанги сам на место");
        }

        int getNextBreaker(Random random, int participatingDriversNumber, List<int> breakers)
        {
            int result;

            do
            {
                result = random.Next(0, participatingDriversNumber);
            }
            while (breakers.Contains(result));

            return result;
        }


        List<int> DetermineBreakers()
        {
            List<int> breakers = new List<int>();
            if (participatingDrivers.Count == 0)
                return breakers;
            Notification($"Соскочили штанги у водителя {Name}:");
            Random random = new Random();

            int firstDriver = getNextBreaker(random, participatingDrivers.Count, breakers);
            breakers.Add(firstDriver);

            PrintWinDriver(participatingDrivers[firstDriver]);

            return breakers;


        }

        void WaitHeal(List<Driver> driversWithProblems)
        {
            bool allHeal = true;

            do
            {
                Task.Delay(100).Wait();

                allHeal = driversWithProblems.Count(Driver => Driver.isBreak) == 0;

            } while (!allHeal);
        }

        void PrintDriversWithProblems(List<Driver> driversWithProblems)
        {
            string message = "";

            foreach (var item in driversWithProblems)
            {
                message += $"{item.nameOfObject} {item.numberOfObject}: {Emergency.AllEmergency[item.EmergencyIndex]}\r\n";
            }

            Notification(message);
        }

        List<Driver> DeterminedriversWithProblems(List<int> breakers)
        {
            List<Driver> driversWithProblems = new List<Driver>();

            Random random = new Random();

            for (int i = 0; i < participatingDrivers.Count; i++)
                if (!breakers.Contains(i))
                {
                    participatingDrivers[i].RandomBreak(random);

                    if (participatingDrivers[i].isBreak)
                        driversWithProblems.Add(participatingDrivers[i]);
                    else
                        participatingDrivers[i].IsLocked = false;
                }

            return driversWithProblems;
        }

        public void EndTrolleybus()
        {
            Notification($"Рейс {Name} закончился");

            List<int> breakers = DetermineBreakers();


            foreach (var item in breakers)
            {
                participatingDrivers[item].IsLocked = false;
            }
            Random random = new Random();

            List<Driver> driversWithProblems = DeterminedriversWithProblems(breakers);

            if (driversWithProblems.Count != 0)
            {
                Notification($"Во время рейса {Name} у водителей случились проишествия\n");

                PrintDriversWithProblems(driversWithProblems);
                Notification($"Пока все не починят, рейс {Name} не начнётся");
                WaitHeal(driversWithProblems);

                Notification($"Рейс {Name}: Все неполадки устранены!");
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                Notification($"Скоро будет рейс {Name}");

                Task.Delay(3 * 1000).Wait();

                if (!StartTrolleybus())
                {
                    Notification($"Водители не явились на работу, рейса {Name} не будет");
                }
                else
                {
                    DoTrolleybus();

                    EndTrolleybus();   
                }
                Task.Delay(5 * 1000).Wait();
            }
        }
    }
}
