using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Placement_Cell
{
    public partial class gridview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True";
            con.Open();

            string com = "Select Cat_id,Category_name from Category";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddl1.DataSource = dt;
            ddl1.DataTextField = "Category_name";
            ddl1.DataValueField = "Cat_id";
            ddl1.DataBind();

             com = "Select Exam_id,Exam_name from Exams";
            adpt = new SqlDataAdapter(com, con);
             dt = new DataTable();
            adpt.Fill(dt);
            ddl2.DataSource = dt;
            ddl2.DataTextField = "Exam_name";
            ddl2.DataValueField = "Exam_id";
            ddl2.DataBind();

        }

        




        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SetInitialRow();

            //con.Open();
            //string com = "SELECT section from tbl_scheme where scheme_id = '" + ddlscheme.SelectedItem.Value + "' ";
            //SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            //DataTable dt = new DataTable();
            //adpt.Fill(dt);

            //DataView dv = dt.DefaultView;
            //int abc = 0;
            //foreach (DataRowView drv in dv)
            //{
            //    abc = Convert.ToInt32(drv.Row["section"]);
            //}

            for (int i = 1; i < 4; i++)
            {
                AddNewRowToGrid();
            }

            Button1.Visible = true;
        }
        private void SetInitialRow()
        {

            DataTable dt = new DataTable();

            DataRow dr = null;

            dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));

            dt.Columns.Add(new DataColumn("Column1", typeof(string)));

            dt.Columns.Add(new DataColumn("Column2", typeof(string)));

            //dt.Columns.Add(new DataColumn("Column3", typeof(string)));

            //dt.Columns.Add(new DataColumn("Column4", typeof(string)));

            //dt.Columns.Add(new DataColumn("Column5", typeof(string)));


            dr = dt.NewRow();

            dr["RowNumber"] = 1;

            dr["Column1"] = string.Empty;

            dr["Column2"] = string.Empty;

            //dr["Column3"] = string.Empty;

            //dr["Column4"] = string.Empty;

            //dr["Column5"] = string.Empty;




            dt.Rows.Add(dr);

            //dr = dt.NewRow();



            //Store the DataTable in ViewState

            ViewState["CurrentTable"] = dt;



            GridView2.DataSource = dt;

            GridView2.DataBind();


        }
        private void AddNewRowToGrid()
        {

            int rowIndex = 0;



            if (ViewState["CurrentTable"] != null)
            {

                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];

                DataRow drCurrentRow = null;

                if (dtCurrentTable.Rows.Count > 0)
                {

                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {

                        //extract the TextBox values

                        TextBox box1 = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("txtA");
                        //TextBox box2 = (TextBox)GridView2.Rows[rowIndex].Cells[2].FindControl("txtB");
                        //TextBox box3 = (TextBox)GridView2.Rows[rowIndex].Cells[3].FindControl("txtC");
                        //TextBox box4 = (TextBox)GridView2.Rows[rowIndex].Cells[4].FindControl("txtD");







                        drCurrentRow = dtCurrentTable.NewRow();

                        drCurrentRow["RowNumber"] = i + 1;



                        dtCurrentTable.Rows[i - 1]["Column1"] = box1.Text;

                        //dtCurrentTable.Rows[i - 1]["Column2"] = box2.Text;

                        //dtCurrentTable.Rows[i - 1]["Column3"] = box3.Text;

                        //dtCurrentTable.Rows[i - 1]["Column4"] = box4.Text;






                        rowIndex++;

                    }

                    dtCurrentTable.Rows.Add(drCurrentRow);

                    ViewState["CurrentTable"] = dtCurrentTable;



                    GridView2.DataSource = dtCurrentTable;

                    GridView2.DataBind();

                }

            }

            else
            {

                Response.Write("ViewState is null");

            }



            //Set Previous Data on Postbacks

            SetPreviousData();

        }

        private void SetPreviousData()
        {

            int rowIndex = 0;

            if (ViewState["CurrentTable"] != null)
            {

                DataTable dt = (DataTable)ViewState["CurrentTable"];

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        TextBox box1 = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("txtA");
                        //TextBox box2 = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("txtB");
                        //TextBox box3 = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("txtC");
                        //TextBox box4 = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("txtD");







                        box1.Text = dt.Rows[i]["Column1"].ToString();
                        //box2.Text = dt.Rows[i]["Column2"].ToString();
                        //box3.Text = dt.Rows[i]["Column3"].ToString();
                        //box4.Text = dt.Rows[i]["Column4"].ToString();







                        rowIndex++;

                    }

                }

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            foreach (GridViewRow gr in GridView2.Rows)
            {
                if (gr.RowType == DataControlRowType.DataRow)
                {
                    TextBox textBox1 = gr.FindControl("txtA") as TextBox;
                    //TextBox textBox2 = gr.FindControl("txtB") as TextBox;
                    //TextBox textBox3 = gr.FindControl("txtC") as TextBox;
                    //TextBox textBox4 = gr.FindControl("txtD") as TextBox;


                    string sql = "insert into Questionanswer(Question_id,Question,Answer1,category_id,Exam_id) values('" + TextBox2.Text.Trim() + "','" + TextBox1.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + ddl1.SelectedItem.Value + "','" + ddl2.SelectedItem.Value + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                   

                        CheckBox cb = (gr.Cells[0].FindControl("chb1") as CheckBox);
                        if (cb.Checked)
                        {

                            string sqll = "insert into Answer(Question_id,Answer) values('" + TextBox2.Text.Trim() + "','" + textBox1.Text.Trim() + "')";
                            SqlCommand cmdd = new SqlCommand(sqll, con);
                            cmdd.ExecuteNonQuery();

                        }


                        //Response.Redirect("gridview.aspx");
                }
            }
        }
    }
}