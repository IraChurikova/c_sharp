using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using лаб1_библиотекаКлассов;



    namespace лаба1_с_шарп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(classOfComfort.Advanced);
            listBox1.Items.Add(classOfComfort.Econom);
            listBox1.Items.Add(classOfComfort.Lux);
            listBox1.Items.Add(classOfComfort.Premium);
            
        }

        Train listtr = new Train();

        private void OutputButton_Click(object sender, EventArgs e) //выводит вагоны поезда
        {
            listBox.Items.Clear();
            int count = listtr.trainList.Count;
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add((i + 1).ToString() + ". " + listtr.trainList[i].makeStr());
            }
        }

        private void TrainlenButton_Click(object sender, EventArgs e) // при нажатии на кнопку выводится кол-во багажа и пассажиров
        {
          
            label1.Text = "Количество пассажиров " + listtr.TrainCapacityByPas()+'\n'+ "Количество багажа "+ listtr.TrainCapacityByBag();
        }


        public bool check(string str) 
        {
            int i = 0;
            Regex r = new Regex(@"[\d.,]");
            Match m = r.Match(str);
            while (m.Success)
            {
                i++;
                m = m.NextMatch();
            }
            if (i!=str.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FindButton_Click(object sender, EventArgs e) //поиск вагонов в заданном диапазоне
        {
            ResTextBox.Clear();
            if (BeginTextBox.Text != "" && EndTextBox.Text != "" && check(BeginTextBox.Text) && check(EndTextBox.Text))
            {
                int first = Convert.ToInt32(BeginTextBox.Text);
                int last = Convert.ToInt32(EndTextBox.Text);
                string str = listtr.findByRangePas(first, last);
                if (str == "")
                {
                    ResTextBox.Text += "Нет поездов в заданном диапазоне";
                }
                else
                {
                    ResTextBox.Text += str;
                    ResTextBox.Text += '\n';
                }
            }
            else
            {
                MessageBox.Show("Вам нужно ввести начало и конец диапазона в соответствующие TextBox");
            }
        }

        private void SortButton_Click(object sender, EventArgs e) //сортировка по классу комфортности
        {
            string input_style = Convert.ToString(listBox1.SelectedItem);
            if (Enum.IsDefined(typeof(classOfComfort), input_style))
            {
                listBox.Items.Clear();
                int count = listtr.trainList.Count;
                var sortlist = listtr.sortByclassOfComfort((classOfComfort)Enum.Parse(typeof(classOfComfort), input_style));
                for (int i = 0; i < count; i++)
                    listBox.Items.Add((i + 1).ToString() + ". " + sortlist[i].makeStr());
            }
            else
            {
                MessageBox.Show("Такого класса комфортности не существует, введите другой");
            }
        }
    }
}
