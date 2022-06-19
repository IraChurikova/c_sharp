using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Main
{
    public partial class SelectEmergenceServiceType : Form
    {
        private readonly IEnumerable<Type> emergenceServiceType;
        public Type SelectedType { get; private set; }
        public SelectEmergenceServiceType(IEnumerable<Type> emergenceServiceType)
        {
            InitializeComponent();

            this.emergenceServiceType = emergenceServiceType;

            SelectedType = null;
        }

      

        private void agreeButton_Click(object sender, EventArgs e)
        {
            if (SelectedType == null)
                MessageBox.Show("Вы не выбрали тип аварийной службы");
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void selectEmergenceServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = emergenceServiceType.First(type => type.Name == selectEmergenceServiceComboBox.SelectedItem.ToString());
            agreeButton.Enabled = true;
        }

        private void SelectEmergenceServiceType_Load(object sender, EventArgs e)
        {
            selectEmergenceServiceComboBox.Items.AddRange(emergenceServiceType.Select(type => type.Name).ToArray());
        }
    }
}
