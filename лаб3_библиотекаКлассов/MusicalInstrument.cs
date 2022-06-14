using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Для интерфейса необходимо определить 1 свойство и 2 метода. 
Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 
Класс должен содержать дополнительно 2 свойства и 2 метода.
В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

21. interface Музыкальный инструмент -> abstract class Гитара -> class Электрогитара.*/

namespace лаба3_библиотекаКлассов
{
    public interface MusicalInstrument 
    {
        int volume { get; set; }
        string play();
        void makeLouder();
    }

    public abstract class Guitar : MusicalInstrument
    {
        public int volume { get; set; }
        public string color { get; set; }
        public int countOfStrings { get; set; }

        public const int standartCountOfStrings = 6;

        public Guitar(int volume, string color, int countOfStrings)
        {
            this.volume = volume;
            this.color = color;
            this.countOfStrings = countOfStrings;
        }
        public string play()
        {
            if (countOfStrings > 0)
                return "Лалала" ;
             else
            {
                return "Ноу Лалала \n Натяни струну";
            }
        }
        
        public void makeLouder()
        {
            volume++;
        }
        public string playBas()
        {
            if (countOfStrings > 0)
                return "Бринг бринг бринг";
            else
            {
                return "Ноу бринг \n Натяни струну";
            }
        }

        public string pullString()
        {
            if (countOfStrings<standartCountOfStrings)
            {
                countOfStrings++;
               return "Вы успешно натянули струну";
            }
            else
            {
                return "Максимум струн, новые не добавить";
            }
        }

        public string breakString()
        {
            if (countOfStrings > 0)
            {
                return "Вы успешно порвали струну";
            }
            else
            {
               return "Струн больше нет...";
            }

        }

    }

    public class ElectroGuitar : Guitar
    {
        public int serialNumber { get; set; }
        public int guitarFrequency { get; set; }

        public ElectroGuitar(int volume, string color, int countOfStrings, int serialNumber, int guitarFrequency) : base(volume, color, countOfStrings)
        {
            this.serialNumber = serialNumber;
            this.guitarFrequency = guitarFrequency;
        }

        public string power()
        {
            return "Устройство готово к использованию!";
        }

        public string showGuitarFrequency()
        {
            string s = Convert.ToString(guitarFrequency);
            return s;
        }

    }
}
