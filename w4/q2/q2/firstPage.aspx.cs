using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q2
{
    public partial class firstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("English");
            DropDownList1.Items.Add("Sanskrit");
            DropDownList1.Items.Add("Greek");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string rollno = TextBox2.Text;
            string subject = DropDownList1.SelectedValue;
            Session["name"] = name;
            Session["rollno"] = rollno;
            Session["subject"] = subject;
            Response.Redirect("secondPage.aspx");
        }
    }
}