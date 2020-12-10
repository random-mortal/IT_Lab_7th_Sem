using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
            DropDownList1.Items.Add("Yash");
            DropDownList1.Items.Add("Aksh");
            DropDownList1.Items.Add("Harsh");

            RadioButtonList1.Items.Add("Yellow");
            RadioButtonList1.Items.Add("Blue");
            RadioButtonList1.Items.Add("Green");
            RadioButtonList1.Items.Add("Red");

        }
    }

   protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs e)
    {
        string contact = TextBox3.Text;
        if(contact.Length!=10)
        {
            e.IsValid = false;
        }
        else
        {
            e.IsValid = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {
            Label6.Text = "Successfully submitted";
        }
        else
        {
            Label6.Text = "";
        }
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}