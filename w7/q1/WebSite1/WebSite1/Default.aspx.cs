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
            List<String> fruits = new List<String>();

            fruits.Add("Apple");
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("Kiwi");
            fruits.Add("Watermelon");

            List<String> ice_cream = new List<String>();

            ice_cream.Add("Chocolate");
            ice_cream.Add("Vanilla");
            ice_cream.Add("Butterscotch");
            ice_cream.Add("Strawberry");

            CheckBoxList1.DataSource = fruits;
            RadioButtonList1.DataSource = ice_cream;

            this.DataBind();


        }
        Label3.Text = "Fruits:";
        Label4.Text = "Ice cream:";
        Label5.Text = "Cost:";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach(ListItem item in CheckBoxList1.Items)
        {
            if(item.Selected==true)
            {
                Label3.Text += item.Text + " ";
            }
        }

        Label4.Text += RadioButtonList1.SelectedValue;

        Random r = new Random();

        Label5.Text += r.Next(100, 200).ToString();
    }
}