using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double currentSalary = 0;
            double.TryParse(salaryTextBox.Text, out currentSalary);

            int selectedLevel = salaryLevelsComboBox.SelectedIndex + 1; // index will start from 0

            double bonusFactor = 0;

            if (selectedLevel == 1)
                bonusFactor = 0.1;
            else if (selectedLevel <= 4)
                bonusFactor = 0.09;
            else if (selectedLevel <= 7)
                bonusFactor = 0.07;
            else //(selectedLevel <= 10)
                bonusFactor = 0.05;

            // set the text
            bonusTextBox.Text = (currentSalary * bonusFactor).ToString();
        }
    }
}
