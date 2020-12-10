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
            Dictionary<int, string> state = new Dictionary<int, string>();

            state.Add(1, "Maharashtra");
            state.Add(2, "Karnataka");
            state.Add(3, "Kerala");
            state.Add(4, "Gujarat");
            state.Add(5, "Rajasthan");

            DropDownList1.DataSource = state;

            DropDownList1.DataTextField = "Value";
            DropDownList1.DataValueField = "Key";

            this.DataBind();
        }
    }

}