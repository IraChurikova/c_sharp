using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Input : Form
    {
        MusicalInstrument musicalInstrument;
        public Input()
        {
            InitializeComponent();
        }

        public void input()
        {
            string color = ColorTextBox.Text;
            int guitarFrequency = Int32.Parse(FrequencyTextBox.Text);
            int countOfStrings = Int32.Parse(CountOfStringsTextBox.Text);
            int serialNumber = Int32.Parse(serialNumberTextBox.Text);
            int volume = Int32.Parse(VolumeTextBox.Text);
            musicalInstrument = new ElectroGuitar(volume, color, countOfStrings, serialNumber, guitarFrequency);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            input();
            MainForm main = this.Owner as MainForm;
            main.add(musicalInstrument);
            this.Close();
        }

    }
}
