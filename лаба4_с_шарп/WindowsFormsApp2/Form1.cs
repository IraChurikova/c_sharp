using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using лаб4_библиотекаКлассов;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type baseType = typeof(Trolleybus);

            // Все наследники
            var allDerivedTypes = baseType.Assembly.ExportedTypes.Where(t => baseType.IsAssignableFrom(t));
            foreach (var m in allDerivedTypes)
            {
                if(m.Name!= "Trolleybus")
               comboBox1.Items.Add(m);
            }

            // Непосредственные наследники
         //   var derivedTypes = baseType.Assembly.ExportedTypes.Where(t => t.BaseType == baseType);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
             Type s1 = (Type)comboBox1.SelectedItem;
           
                Trolleybus instance = (Trolleybus)Activator.CreateInstance(s1);
                var metods = Reflect.GetMethod<Trolleybus>(instance);
                foreach (MethodInfo q in metods)
                {
                    comboBox2.Items.Add(q);

                }
            
           
        }
        private void func()
        {
            textBox1.Enabled = true;
           // textBox1.Text = "7"; 
            //while (button4.Enabled)
            //{

            //}
            textBox1.Enabled = false;
            button4.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*  ParameterInfo[] p = m.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    s+=p[i].ParameterType.Name + " " + p[i].Name;
                    if (i + 1 < p.Length)
                    {
                       s+=", ";
                    }
                }*/
            Type s1 = (Type)comboBox1.SelectedItem;
            Trolleybus instance = (Trolleybus)Activator.CreateInstance(s1);
            MethodInfo methodInfo = (MethodInfo)comboBox2.SelectedItem;
            ParameterInfo[] parameters = methodInfo.GetParameters();
            string s = "";
            object[] mas = new object[parameters.Length];
            int i = 0;
            foreach(ParameterInfo p in parameters)
            {
                s += Convert.ToString(p.ParameterType);
                Type type = (p.ParameterType);
                //func();
                mas[i] = Convert.ChangeType(textBox1.Text,type);
                i++;
                s += " ";
            }
            var k = methodInfo.Invoke(instance, mas);
            label1.Text = Convert.ToString(k);
            label3.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }
    }
}
