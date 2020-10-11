using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["sportsConnectionString2"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from items where id = @p1", con);
            cmd.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            TextBox3.Text = rdr["ItemName"].ToString();
            TextBox2.Text = rdr["QtyOnHand"].ToString();
            TextBox4.Text = rdr["CostPer"].ToString();
            TextBox5.Text = rdr["ReorderPoint"].ToString();
            rdr.Close();
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Items  set ItemName=@p1, QtyOnHand=@p2, ReorderPoint=@p3, CostPer=@p4 where id= @p5", con);
            cmd.Parameters.AddWithValue("@p1", TextBox3.Text );
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", TextBox5.Text);
            cmd.Parameters.AddWithValue("@p4", TextBox4.Text);
            cmd.Parameters.AddWithValue("@p5", DropDownList1.SelectedValue);
            con.Open();
            int retval = cmd.ExecuteNonQuery();
            con.Close();
            if (retval > 0)
            {
                Label4.Text = "Changes Saved";
            }

        }
    }
}