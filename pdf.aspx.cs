using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace Placement_Cell
{
    public partial class pdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewgrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;
            FileUpload1.SaveAs(Server.MapPath("~/Upload folder/") + filename);
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True");
                    con.Open();
                    string sql = "insert into tbl_pdf(content_type,file_name,data)values('" + FileUpload1.FileContent + "','" + FileUpload1.FileName + "','"+ FileUpload1.FileBytes +"')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    viewgrid();





                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void viewgrid()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select file_name from tbl_pdf", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = dt;

            GridView1.DataBind();
        }
    }
}
    