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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string place = ListBox1.SelectedValue;
        string url = "Second.aspx?place=" + Server.UrlEncode(place);
        Response.Redirect(url);
    }
}