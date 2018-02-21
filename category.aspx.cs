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
    public partial class category : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   String ins = "insert into category values ('" + DropDownList1.SelectedItem.Text.Trim() + "',)";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ins = "insert into category (Category_name) values('" + DropDownList1.SelectedItem.Text.Trim() + "')";
            SqlCommand cmd = new SqlCommand(ins, con);
            cmd.ExecuteNonQuery();
            //DropDownList1.Text = "";
            Response.Write("<script LANGUAGE='JavaScript'>alert('Data Added Successfullyy')</script>");
        }
    }
}