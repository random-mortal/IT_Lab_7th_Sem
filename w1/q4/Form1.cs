using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            string name = this.nameComboBox.GetItemText(this.nameComboBox.SelectedItem);

            string colour = this.colourComboBox.GetItemText(this.colourComboBox.SelectedItem);

            string model = this.modelListBox.GetItemText(modelListBox.SelectedItem);

            string price = this.priceTextBox.Text;

            string message = "Thank you for purchasing a " + colour + " " + name + " (" + model + " model) for " + price + " INR.";
            
            MessageBox.Show(message);

         
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            nameComboBox.Text = "";

            colourComboBox.Text = "";

            modelListBox.ClearSelected();

            priceTextBox.Text = "";
        }

        private void colourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
