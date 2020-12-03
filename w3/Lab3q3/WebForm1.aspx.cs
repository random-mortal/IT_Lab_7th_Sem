using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
namespace Lab3q3
{
    public partial class Card : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                backColor.Items.Add("Blue");
                backColor.Items.Add("Green");
                backColor.Items.Add("Yellow");
                backColor.Items.Add("Red");
                fontFamily.Items.Add("Times New Roman");
                fontFamily.Items.Add("Arial");
                fontFamily.Items.Add("Calibri");
                fontFamily.Items.Add("Georgia");
                imageList.Items.Add(new ListItem("Scenery 1", "c1.jpg"));
                imageList.Items.Add(new ListItem("Scenery 2", "c2.jpg"));
            }
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            pnlCard.BackColor = Color.FromName(backColor.SelectedValue.ToString());
            pnlCard.Font.Name = fontFamily.SelectedValue.ToString();
            int a = 0;
            int.TryParse(fontSize.Text, out a);
            display.Font.Size = a;
            dp.ImageUrl = imageList.SelectedItem.Value;
            dp.Visible = true;
            display.Text = message.Text;
        }
        protected void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            dp.ImageUrl = "default.jpg";
            pnlCard.BackColor = Color.FromName("White");
            message.Text = " ";
            fontSize.Text = " ";
        }
    }
}