using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class First : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("Apple Iphone XR","Screen:828x1792 pixels,Memory:3GB RAM,Camera:12MP,Battery:2942 mAh"));
            DropDownList1.Items.Add(new ListItem("Samsung Galaxy S10", "Screen:700x1792 pixels,Memory:4GB RAM,Camera:10MP,Battery:1942 mAh"));
            DropDownList1.Items.Add(new ListItem("Sony Xperia XZ2", "Screen:828x1792 pixels,Memory:3GB RAM,Camera:13MP,Battery:2742 mAh"));
            DropDownList1.Items.Add(new ListItem("Nokia 7.2", "Screen:828x1792 pixels,Memory:3GB RAM,Camera:12MP,Battery:2942 mAh"));

        }
    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["info"] = DropDownList1.SelectedValue;
        Response.Redirect("Second.aspx");
        
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label Label3 = (Label)this.Master.FindControl("Label3");
        Label3.Text = DropDownList1.SelectedItem.Text;
    }
}

