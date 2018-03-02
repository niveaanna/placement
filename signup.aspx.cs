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
    public partial class signup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        
        {
            con.ConnectionString=@"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();
    
            

        }

        protected void btnsignup_Click(object sender, EventArgs e)
        {
           

                        string Label1 = txtuser.Text;
            string Label2 = txtpassword.Text;
            String sel = " select Username,Password from Registrations where username='" + txtuser.Text + "'and password='" + txtpassword.Text + "'";
           
            SqlCommand cmd = new SqlCommand(sel, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

              
                if (dt.Rows.Count > 0)
                {
                    Session["Password"] = dt.Rows[0][0].ToString();
                    Session["Username"] = dt.Rows[0][1].ToString();

                    Response.Redirect("user_registrationupdate.aspx");

                    txtuser.Text = "";
                    txtpassword.Text = "";
                }
                
                else
                {
                   // Response.Write("Login Unsucessfull");
                    String seltbl = " select Username,Password from signup where username='" + txtuser.Text + "'and password='" + txtpassword.Text + "'";
                    txtuser.Text = "";
                    txtpassword.Text = "";
                    Response.Redirect("view student.aspx");
                    

                }
            
            
        }

        protected void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

       // protected void txtuser_TextChanged(object sender, EventArgs e)
      //  {

       // }
        }

        }
    




        
    
