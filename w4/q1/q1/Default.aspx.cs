using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("Honda"));
                DropDownList1.Items.Add(new ListItem("Hyundai"));
                DropDownList1.Items.Add(new ListItem("Skoda"));
                DropDownList1.Items.Add(new ListItem("Toyota"));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = TextBox1.Text;
            string manufacturer = DropDownList1.SelectedValue;

            string url = "newpage.aspx?model=" + Server.UrlEncode(model) + "&manufacturer=" + Server.UrlEncode(manufacturer);
            Response.Redirect(url);
        }


    }
}