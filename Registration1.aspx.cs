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
    public partial class Registration1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
           Panel1.Visible = false;
           panel2.Visible = false;
        }
           public void getcon() 
           {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
           }
         protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedItem.Text == "Student")
            {
                Panel1.Visible = true;
            }
            else if (RadioButtonList2.SelectedItem.Text == "Company")
            {
                panel2.Visible = true;
            }
            else
            {
                Response.Write("please choose a one!");
            }
         }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
           
           getcon();
            String ins = "insert into Registrations values ('" + txtname.Text + "','" + RadioButtonList1.Text + "','" + txtbranch.Text + "','"+ txtsem.Text+"','" + txtuser.Text + "','" +txtpass.Text + "','" + txtcon.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "','" +txtcontact.Text + "')";
             cmd = new SqlCommand(ins, con);
            cmd.ExecuteNonQuery();
            Response.Write("saved sucessfully");
            txtname.Text = "";
            RadioButtonList1.Text = "";
            txtbranch.Text = "";
            txtsem.Text = "";
            txtuser.Text = "";
            txtpass.Text = "";
            txtcon.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            Response.Redirect("Login.aspx");
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
          
           getcon();
            String ins = "insert into company values ('" + txtcomname.Text + "','" + txtmail.Text + "','" + txtno.Text + "','" + txtusern.Text + "','" + txtpswrd.Text + "','" + txtconpass.Text + "')";
            cmd = new SqlCommand(ins, con);
            cmd.ExecuteNonQuery();
            Response.Write("saved sucessfully");
            txtcomname.Text = "";
            txtmail.Text = "";
            txtno.Text = "";
            txtusern.Text = "";
            txtpswrd.Text = "";
            txtconpass.Text = "";
            

        }

        protected void txtusern_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        
    }
}