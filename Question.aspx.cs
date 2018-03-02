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
    public partial class test : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            String ins = "insert into Question1(Quest,crct_option) values ('" + txtquest.Text + "','"+RadioButtonList1.SelectedItem.Text+"')";
            SqlCommand cmd = new SqlCommand(ins, con);
            cmd.ExecuteNonQuery();
            txtquest.Text = "";
           // RadioButtonList1.Text = "";

            Response.Write("success");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}