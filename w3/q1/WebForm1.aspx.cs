using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                backList.Items.Add("White");
                backList.Items.Add("Red");
                backList.Items.Add("Blue");
                backList.Items.Add("Yellow");

                imageList.Items.Add(new ListItem("Santro", "Santro.png"));
                imageList.Items.Add(new ListItem("Ikon", "Ikon.png"));
                imageList.Items.Add(new ListItem("Lancer", "Lancer.png"));
                imageList.Items.Add(new ListItem("Cruz", "Cruz.png"));

                headingFamily.Items.Add("Arial");
                headingFamily.Items.Add("Times New Roman");
                headingFamily.Items.Add("Georgia");
                headingFamily.Items.Add("Helvetica");
               
                bodyFamily.Items.Add("Arial");
                bodyFamily.Items.Add("Times New Roman");
                bodyFamily.Items.Add("Georgia");
                bodyFamily.Items.Add("Helvetica");

            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            pnlMag.BackColor = ColorTranslator.FromHtml(backList.SelectedItem.Text);
            dp.ImageUrl = imageList.SelectedItem.Value;

            heading.Font.Name = headingFamily.SelectedItem.Text;
            heading.Font.Size = FontUnit.Parse(headingSize.Text);
            heading.ForeColor = ColorTranslator.FromHtml(headingColor.Text);
            heading.Text = headingText.Text;

            body.Font.Name = bodyFamily.SelectedItem.Text;
            body.Font.Size = FontUnit.Parse(bodySize.Text);
            body.ForeColor = ColorTranslator.FromHtml(bodyColor.Text);
            body.Text = bodyText.Text;

            dp.Visible = true;
        }
    }
}