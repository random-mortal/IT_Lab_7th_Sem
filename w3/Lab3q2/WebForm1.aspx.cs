using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Lab3q2
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                employeeList.Items.Add(new ListItem("001", "1.png"));
                employeeList.Items.Add(new ListItem("002", "2.png"));
                employeeList.Items.Add(new ListItem("003", "3.png"));
                employeeList.Items.Add(new ListItem("004", "4.png"));
            }
        }

        protected void promotion_Click(object sender, EventArgs e)
        {
            empImage.ImageUrl = employeeList.SelectedItem.Value;
            DateTime datejoin = Convert.ToDateTime(doj.Text);
            DateTime now = DateTime.Now;
            int days = (now - datejoin).Days;
            int years = days / 365;
            if (years >= 5)
            {
                output.Text = "Congrats,you are eligible.";
            }
            else
            {
                output.Text = "Sorry, you are not eligible.";
            }
        }

        protected void empChanged(object sender, EventArgs e)
        {
            empImage.ImageUrl = employeeList.SelectedItem.Value;
            Console.WriteLine("heeeeeeeeeee");
        }
    }
}