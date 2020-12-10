using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Second : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string info = (string)Session["info"];
        string[] list = info.Split(',');
        Label1.Text = list[0];
        Label2.Text = list[1];
        Label3.Text = list[2];
        Label4.Text = list[3];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("First.aspx");
    }
}