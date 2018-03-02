using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace placement
{
    public partial class studentcv : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }
        String val;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(rbtyes.Checked)
            {
                val="Yes";

            }
            else if (rbtno.Checked)
            {
                val="No";
            }
            String ins = "insert into studentcv(stud_id,post_gruaduation,gruadation,[12],[10],abv_60) values ('" + txtstudid.Text + "','"+ txtpost.Text+"','"+ txtgruadation.Text+"','"+ txt12.Text+"','"+ txt10.Text+"','"+ val +"')";
            SqlCommand cmd = new SqlCommand(ins, con);
            cmd.ExecuteNonQuery();
            
            txtstudid.Text="";
            txtpost.Text="";
            txtgruadation.Text="";
            txt12.Text="";
            txt10.Text="";

            Response.Write("successfully inserted");

        }
    }
}