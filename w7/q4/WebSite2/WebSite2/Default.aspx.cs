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
            List<String> category = new List<String>();

            category.Add("comedy");
            category.Add("romance");
            category.Add("animated");

            DropDownList1.DataSource = category;
            this.DataBind();
        }
    }
}