using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Placement_Cell
{
    public partial class viewpdf : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            viewgrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void viewgrid() //course grid function
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select file_name from tbl_pdf", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = dt;

            GridView1.DataBind();
        }
    }
}