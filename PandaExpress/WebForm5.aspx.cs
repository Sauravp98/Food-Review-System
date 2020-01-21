using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PandaExpress
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if (cookie != null)
                Page.Theme = cookie["User_Themes"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome " + Session["Salutation"];
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            string query = "Select count(*) as cnt from Comments where status=0";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string com_count = reader["cnt"].ToString();
            if (com_count == null)
                com_count = "0";
            string x = "You have " + com_count + " new comment(s)";
            lbl.Text = x;
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebForm9.aspx");
        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebForm7.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm8.aspx");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm10.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["Salutation"] = null;
            Session["Uid"] = null;
            Response.Redirect("WebForm1.aspx");
        }
    }
}