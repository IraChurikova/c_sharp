using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Для интерфейса необходимо определить 1 свойство и 2 метода. 
Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 
Класс должен содержать дополнительно 2 свойства и 2 метода.
В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

21. interface Музыкальный инструмент -> abstract class Гитара -> class Электрогитара.*/

namespace лаба3_с_шарп
{
    public interface MusicalInstrument 
    {
        int volume { get; set; }
        void play();
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
        public void play()
        {
            if (countOfStrings > 0)
                MessageBox.Show("Лалала");
             else
            {
                MessageBox.Show("Ноу Лалала \n Натяни струну");
            }
        }
        
        public void makeLouder()
        {
            volume++;
        }
        public void playBas()
        {
            if (countOfStrings > 0)
                MessageBox.Show("Бринг бринг бринг");
            else
            {
                MessageBox.Show("Ноу бринг \n Натяни струну");
            }
        }

        public void pullString()
        {
            if (countOfStrings<standartCountOfStrings)
            {
                countOfStrings++;
                MessageBox.Show("Вы успешно натянули струну");
            }
            else
            {
                MessageBox.Show("Максимум струн, новые не добавить");
            }
        }

        public void breakString()
        {
            if (countOfStrings > 0)
            {
                MessageBox.Show("Вы успешно порвали струну");
            }
            else
            {
                MessageBox.Show("Струн больше нет...");
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

        public void power()
        {
            MessageBox.Show("Устройство готово к использованию!");
        }

        public void showGuitarFrequency()
        {
            string s = Convert.ToString(guitarFrequency);
            MessageBox.Show(s);
        }

    }
}
