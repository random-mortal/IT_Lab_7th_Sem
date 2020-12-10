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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string company = TextBox2.Text;
        string salary = TextBox3.Text;

        string connection_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=WorksAndLives;Integrated Security=True;Pooling=False";

        SqlConnection con = new SqlConnection(connection_string);

        string query = "INSERT INTO Works (name,company,salary) VALUES ('"+name+"','"+company+"','"+salary+"')";

        SqlCommand cmd = new SqlCommand(query, con);

        int added = 0;
        try
        {
            con.Open();

            added = cmd.ExecuteNonQuery();
        }
        catch(Exception err)
        {

        }
        finally
        {
            con.Close();
        }

        if(added>0)
        {
            Label4.Text = "Successfully added";
        }
        else
        {
            Label4.Text = "Values were not added";
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        ListBox1.Items.Clear();
        string company = TextBox4.Text;

        string connection_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=WorksAndLives;Integrated Security=True;Pooling=False";

        string query = "SELECT Lives.name name,Lives.city city FROM Works,Lives where company='" + company + "' AND Works.name=Lives.name";

        SqlConnection con = new SqlConnection(connection_string);

        SqlCommand cmd = new SqlCommand(query, con);

        SqlDataReader reader;

        try
        {
            con.Open();

            reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                string name = (string)reader["name"];
                string city = (string)reader["city"];
                ListBox1.Items.Add(name + " " + city);
            }

        }
        catch(Exception err)
        {

        }
        finally
        {
            con.Close();
        }
    }
}