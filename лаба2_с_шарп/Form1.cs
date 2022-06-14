using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using лаб2_библиотекаКлассов;

    //Задача 21
    //Дом: 
    //-номер дома; -число квартир; -год сооружения.
    //Q = (число квартир)+2• (Т– год сооружения), где Т - текущий год 
    //P: район(центр, окраина, и тп) Qp: если район -центр, то Qp = 2•Q; иначе Qp = 0,5•Q 


    namespace лаба2_с_шарп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Home> homes = new List<Home>(); 
        public List<ExstraHome> ExstraHome = new List<ExstraHome>();

        private void withCountrycheckbtn_CheckedChanged(object sender, EventArgs e) 
        {
            if (withDistrictcheckbtn.Checked)
            {
                MessageBox.Show("Вы можете ввести район в соответствующий TextBox");
                DistricttextBox.Enabled = true;
            }
        }

        private void withoutCountrycheckbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (withoutDistrictcheckbtn.Checked)
            {
                DistricttextBox.Enabled = false;
            }
        }


        private void inputButton_Click(object sender, EventArgs e) //добавление
        {
            homes.Add(new Home(Convert.ToInt32(HometextBox.Text), Int32.Parse(FlattextBox.Text), Int32.Parse(YeartextBox.Text)));
            if (withDistrictcheckbtn.Checked)
            {
               ExstraHome.Add(new ExstraHome(Convert.ToInt32(HometextBox.Text), Int32.Parse(FlattextBox.Text), Int32.Parse(YeartextBox.Text), DistricttextBox.Text));
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            FirstClasslistBox.Items.Clear();
            int count = homes.Count;
            for (int i = 0; i < count; i++)
            {
                FirstClasslistBox.Items.Add((i + 1).ToString() + ". " + homes[i].makeStr() + ", Квалификация дома: " + homes[i].qualityOfHome());
            }
            SecondClasslistBox.Items.Clear();
            int count_2 = ExstraHome.Count;
            for (int i = 0; i < count_2; i++)
            {
                SecondClasslistBox.Items.Add((i + 1).ToString() + ". " + ExstraHome[i].makeStr() + ", Квалификация дома: " + ExstraHome[i].qualityOfHome());
            }
        }
    }
}
