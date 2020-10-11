using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Final
{
    public partial class Inquiry : Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["sportsConnectionString2"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

    }
}