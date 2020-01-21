using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PandaExpress
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label6.Text = "Welcome " + Session["Salutation"]; 
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if (cookie != null)
                Page.Theme = cookie["User_Themes"];
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLlocalDB; Initial Catalog = abcd; Integrated Security = True";
            SqlCommand cmd = new SqlCommand("INSERT INTO HOTEL (Name,Cuisine,Location,Rating,Owner) VALUES (@m1, @m2, @m3, @m4, @m5)", con);
            cmd.Parameters.AddWithValue("@m1", tb1.Text);
            cmd.Parameters.AddWithValue("@m2", tb2.Text);
            cmd.Parameters.AddWithValue("@m3", tb3.Text);
            float v;
            float.TryParse(tb4.Text, out v);
            cmd.Parameters.AddWithValue("@m4", v);
            cmd.Parameters.AddWithValue("@m5", tb5.Text);
            con.Open();
            int y = cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Salutation"] = null;
            Session["Uid"] = null;
            Response.Redirect("WebForm1.aspx");
        }
    }
}