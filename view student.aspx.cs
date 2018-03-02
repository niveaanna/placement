using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace placement
{
    public partial class view_student : System.Web.UI.Page
    { 
        SqlConnection con = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
                        if (!IsPostBack)
            {
                grid();
            }

        }
        public void getcon()
        {
            con.ConnectionString =@"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }
        public void grid()
        {
            getcon();
            string str = "select * from Registrations";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter adr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}