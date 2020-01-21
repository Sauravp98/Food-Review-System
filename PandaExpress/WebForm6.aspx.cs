using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PandaExpress
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        private DataSet ds = new DataSet();
        private DataSet ds1 = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome " + Session["Salutation"];
            //Update count
            string s1 = Request.QueryString["name"];
            int s2 = Convert.ToInt32(Request.QueryString["rid"]);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";

            string query = "Select * from HOTEL Where Name=@pp1 AND Id = @pp2";
            string query2 = "Select * from Comments Where Rest_ID=@ppp1 and Status=1";
            SqlCommand cmd = new SqlCommand(query, con);
                           
            cmd.Parameters.AddWithValue("@pp1", s1);
            cmd.Parameters.AddWithValue("@pp2", s2);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "HOTEL");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            cmd = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@ppp1", s2);
            con.Open();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(ds1, "Comments");
            con.Close();
            GridView2.DataSource = ds1;
            GridView2.DataBind();


        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if (cookie != null)
                Page.Theme = cookie["User_Themes"];
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string comment = TextBox1.Text;
            int rid = Convert.ToInt32(Request.QueryString["rid"]);
            int uid = Convert.ToInt32(Session["Uid"]);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            string query = "INSERT INTO Comments (Cmt_Text,Commenter,Rest_Id,Status) values (@text,@comt,@rest,@status)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@text",comment);
            cmd.Parameters.AddWithValue("@comt",uid);
            cmd.Parameters.AddWithValue("@rest", rid);
            cmd.Parameters.AddWithValue("@status",0);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Salutation"] = null;
            Session["Uid"] = null;
            Response.Redirect("WebForm1.aspx");
        }
    }
}