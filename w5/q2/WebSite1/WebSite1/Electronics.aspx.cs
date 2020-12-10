using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Electronics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
            DropDownList1.Items.Add("Apple");
            DropDownList1.Items.Add("Samsung");
            DropDownList1.Items.Add("Sony");
            DropDownList1.Items.Add("Nokia");

            DropDownList2.Items.Add("Dell");
            DropDownList2.Items.Add("Acer");
            DropDownList2.Items.Add("HP");

            DropDownList3.Items.Add("Canon");
            DropDownList3.Items.Add("Epson");
            DropDownList3.Items.Add("Brother");
        }
    }
}