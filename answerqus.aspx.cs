using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Placement_Cell
{
    public partial class answerqus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                getData(this.User.Identity.Name);
            }

        }

        private void getData(string user)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select distinct Question,Qus_id from tbl_question", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

          
            if (dt.Rows.Count > 0)
            {
                rptQues.DataSource = dt;
                rptQues.DataBind();

            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=placement;Integrated Security=True");
                con.Open();
                //HiddenField hdn = new HiddenField();hdn= (HiddenField)FindControl("HiddenField1");
                // string carrierName = ((String)e.Item.DataItem)["carrierName"].ToString();
                DataRowView dr = (DataRowView)e.Item.DataItem;
                string strcarrierName = Convert.ToString(dr["Qus_id"]);
                SqlCommand cmd = new SqlCommand("select Options from Options where Qus_id= '" + strcarrierName + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    
                    Repeater rptOrders = e.Item.FindControl("rptOption") as Repeater;
                    rptOrders.DataSource = dt;
                    rptOrders.DataBind();
                    //RadioButtonList rdoLst = new RadioButtonList();
                    //rdoLst.DataSource = dt;
                    //rdoLst.DataTextField = "Options";
                    //rdoLst.DataBind();

                    RadioButtonList rdot = e.Item.FindControl("rdoTest") as RadioButtonList;
                    rdot.DataSource = dt;
                    rdot.DataTextField = "Options";
                    rdot.DataBind();


                    //PlaceHolder plc = e.Item.FindControl("plchldr") as PlaceHolder;
                    //plc.Controls.Add(rdoLst);

                }
            }


        }
    }
}
        