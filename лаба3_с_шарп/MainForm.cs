using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using лаба3_библиотекаКлассов;


namespace лаба3_с_шарп
{
    public partial class MainForm : Form
    {
        List<MusicalInstrument> MusicalInstruments = new List<MusicalInstrument>();
        ElectroGuitar guitar = new ElectroGuitar(23, "Gray", 4, 2323, 120);
        public MainForm()
        {
            InitializeComponent();
        }

        public void add(MusicalInstrument divace)
        {
            MusicalInstruments.Add(divace);
        }

        public void output()
        { 
            listBox1.Items.Clear();
            foreach (ElectroGuitar guitar in MusicalInstruments)
            {
                listBox1.Items.Add(guitar.volume + " " + guitar.color + " " + guitar.countOfStrings.ToString() + " " + guitar.serialNumber.ToString() + " " + guitar.guitarFrequency.ToString());
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Input form = new Input();
            form.Owner = this;
            form.ShowDialog();
            output();
            listBox1.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MusicalInstruments.Count > 0)
            {
                MusicalInstruments.RemoveAt(listBox1.SelectedIndex);
                output();
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы 1 элемент");
            }
        }

        private void valueButton_Click(object sender, EventArgs e)
        {
            int value = new Random().Next(0, 100);
            guitar.power();
        }

        private void pullStringButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guitar.pullString());
        }

        private void breakStringButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guitar.breakString());
        }

        private void playBasButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guitar.playBas());
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guitar.play());
        }

        private void makeLouderButton_Click(object sender, EventArgs e)
        {
            guitar.makeLouder();
        }

        private void showGuitarFrequencyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guitar.showGuitarFrequency());
           
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
