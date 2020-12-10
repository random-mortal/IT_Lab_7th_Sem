using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
            DropDownList1.Items.Add("Comedy");
            DropDownList1.Items.Add("Romance");
            DropDownList1.Items.Add("Animated");

        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string category = DropDownList1.SelectedValue;
        string connection_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=test;Integrated Security=True;Pooling=False";

        string query = "SELECT name,age from Legends WHERE category='" + category+"'";

        SqlConnection con = new SqlConnection(connection_string);

        SqlCommand cmd = new SqlCommand(query, con);

        

        try
        {
            con.Open();
           
            ListBox1.DataSource = cmd.ExecuteReader();
            ListBox1.DataTextField = "name";
            ListBox1.DataValueField = "age";
            ListBox1.DataBind();
            
            

        }
       catch(Exception err)
        {
           
        }
        finally
        {
            con.Close();
        }

        ListBox1.SelectedIndex = -1;


    }



    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string name = ListBox1.SelectedItem.Text;
        string age = ListBox1.SelectedValue;
        TextBox1.Text = "Name:" + name + "\n" + "Age:" + age;


    }
}