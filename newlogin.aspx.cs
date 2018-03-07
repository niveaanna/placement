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
    public partial class newlogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                SqlCommand cmd = new SqlCommand("select * from Registrations where username =@username and password=@password", con);

                cmd.Parameters.AddWithValue("@username", txtuname.Text);

                cmd.Parameters.AddWithValue("@password", txtpass.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    Response.Redirect("Studentupdate.aspx");


                }
                else if (txtuname.Text == "admin" && txtpass.Text == "admin")
                {
                    Response.Redirect("placementnews.aspx");
                }
                else
                {

                    SqlCommand cmd1 = new SqlCommand("select * from company where username =@username and password=@password", con);

                    cmd1.Parameters.AddWithValue("@username", txtuname.Text);

                    cmd1.Parameters.AddWithValue("@password", txtpass.Text);

                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    if (dt1.Rows.Count > 0)
                    {

                        Response.Redirect("viewstudent.aspx");
                    }
                    else
                    {

                        txtuname.Text = "";
                        txtpass.Text = "";
                        Response.Write("<script language=javascript>alert('Invalid username and password')</script>");
                    }
                }

                //else

                //        txtuname.Text = "";
                //    txtpass.Text = "";
                //    Response.Write("<script language=javascript>alert('Invalid username and password')</script>");

                //    Response.Redirect("Login.aspx");
            
        }
    }
}