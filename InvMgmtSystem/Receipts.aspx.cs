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
    public partial class WebForm1 : System.Web.UI.Page
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
            Label1.Text = rdr["ItemName"].ToString();
            TextBox1.Text = "";
            TextBox2.Text = DateTime.Now.ToString("MM-dd-yyyy");
            rdr.Close();
            con.Close();

        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            string tbdate = TextBox2.Text;
            string dbdate = tbdate.Substring(6, 4) + "-" + tbdate.Substring(0, 2) + "-" + tbdate.Substring(3, 2);
            SqlCommand cmd = new SqlCommand("insert into Receipts (itemId,qty,date,supplierid,userid) values (@p1,@p2,@p3,@p4,@p5)", con);
            cmd.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p3", dbdate);
            cmd.Parameters.AddWithValue("@p4", DropDownList2.SelectedValue);
            cmd.Parameters.AddWithValue("@p5", "1");
            con.Open();
            int retval = cmd.ExecuteNonQuery();
            con.Close();
            if (retval > 0)
            {
                Label4.Text = "Record Saved";
            }
            int dbamt = Convert.ToInt32(TextBox1.Text);
            SqlCommand cmd2 = new SqlCommand("Update Items  set QtyOnHand = QtyOnHand + "+dbamt+ "where id= @p2", con);
            cmd2.Parameters.AddWithValue("@p2", DropDownList1.SelectedValue);
            con.Open();
            int retval2 = cmd2.ExecuteNonQuery();
            con.Close();
            if (retval2 > 0)
            {
                Label4.Text = "Changes Saved";
            }
        }


        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Supplier where id = @p1", con);
            cmd.Parameters.AddWithValue("@p1", DropDownList2.SelectedValue);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Label7.Text = rdr["Name"].ToString();
            rdr.Close();
            con.Close();

        }
    }
}