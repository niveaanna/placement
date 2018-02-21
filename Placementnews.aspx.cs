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
    public partial class Placementnews : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ins = "insert into Placementnews values ('" + txtcompanyname.Text + "','" + txtpost.Text + "','" + txtcriteria.Text + "','" + txtyear.Text + "','" + txtvenue.Text + "','" + txtinformation.Text +"')";

            SqlCommand cmd = new SqlCommand(ins, con);


            cmd.ExecuteNonQuery();
            Response.Write("saved sucessfully");

            txtcompanyname.Text = "";
            txtpost.Text = "";
            txtcriteria.Text = "";
            txtyear.Text = "";
            txtvenue.Text = "";
            txtinformation.Text = "";
            
       
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtcompanyname.Text = "";
            txtpost.Text = "";
            txtcriteria.Text = "";
            txtyear.Text = "";
            txtvenue.Text = "";
            txtinformation.Text = "";
        }
    }
}