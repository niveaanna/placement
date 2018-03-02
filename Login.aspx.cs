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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }



       // protected void btnlogin_Click(object sender, EventArgs e)
       // {

       // }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem.Text == "Admin")
            {

          
                String sel = "select * from signup where username='" + txtname.Text + "' and password='" + txtpass.Text + "'";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Session["Password"] = dt.Rows[0][0].ToString();
                    Session["Username"] = dt.Rows[0][1].ToString();

                    Response.Write("Login Sucessfull");
                    Response.Redirect("view student.aspx");

                }
                else
                {
                    Response.Write("Login Unsucessfull");
                }
            }
            else if (RadioButtonList1.SelectedItem.Text == "Student")
            {
                String sel = "select username,password from Registrations where Username='" + txtname.Text + "' and Password='" + txtpass.Text + "'";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["password"] = dt.Rows[0][0].ToString();
                    Session["username"] = dt.Rows[0][1].ToString();
                    
                    Response.Redirect("user_registrationupdate.aspx");
                }
                else
                {
                    Response.Write("Login Unsucessfull");
                }
            }
            else if (RadioButtonList1.SelectedItem.Text == "Company")
            {
                String sel = "select username,password from company where Username='" + txtname.Text + "' and Password='" + txtpass.Text + "'";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["password"] = dt.Rows[0][0].ToString();
                    Session["username"] = dt.Rows[0][1].ToString();

                    Response.Redirect("view student.aspx");
                }
                else
                {
                    Response.Write("Login Unsucessfull");
                }
            }
        }
        }
    }


        