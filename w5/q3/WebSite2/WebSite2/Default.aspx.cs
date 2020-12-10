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
            DropDownList1.Items.Add("Summer");
            DropDownList1.Items.Add("Monsoon");
        }
    }

    protected void Page_PreInit(object sender,EventArgs e)
    {
        if(Session["theme"]!=null)
        {
            this.Theme = (string)Session["theme"];
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string theme = DropDownList1.SelectedValue;
        Session["theme"] = theme;
        Server.Transfer(Request.FilePath);
    }
}