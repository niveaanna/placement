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
    public partial class user_registrationupdate : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          String sel = "Select Name,Gender,Branch,Sem,Username,Password,Confirm_password,Address,Email,Contact_no from Registrations where Stud_id='"+ TextBox1.Text.ToString() +"'";
          SqlCommand cmd = new SqlCommand(sel, con);
          SqlDataAdapter sd = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TextBox2.Text = dt.Rows[0][0].ToString();
                RadioButtonList1.Text = dt.Rows[0][1].ToString();
                TextBox3.Text = dt.Rows[0][2].ToString();
                TextBox4.Text = dt.Rows[0][3].ToString();
                TextBox5.Text = dt.Rows[0][4].ToString();
                TextBox6.Text = dt.Rows[0][5].ToString();
                TextBox7.Text = dt.Rows[0][6].ToString();
                TextBox8.Text = dt.Rows[0][7].ToString();
                TextBox9.Text = dt.Rows[0][8].ToString();
                TextBox10.Text = dt.Rows[0][9].ToString();
            }
            else
            {
                Response.Write("Invalid Id!");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            String update = "update registrations set Name='" + TextBox2.Text + "',Gender='" + RadioButtonList1.Text + "',Branch='" + TextBox3.Text + "',Sem='" + TextBox4.Text + "',Username='" + TextBox5.Text + "',Password='" + TextBox6.Text + "',Confirm_password='" + TextBox7.Text + "',Address='" + TextBox8.Text + "',Email='" + TextBox9.Text + "',Contact_no='" + TextBox10.Text + "' where Stud_id='"+TextBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();

            Response.Write("successfull");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
          
        }

    }
}