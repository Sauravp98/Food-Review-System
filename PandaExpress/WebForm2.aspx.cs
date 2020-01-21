using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PandaExpress
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if(cookie!=null)
                Page.Theme = cookie["User_Themes"];
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s1 = TextBox1.Text;
            string s2 = TextBox2.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            string d = "Select Id,Username,Password,User_Type from UserDetails";
            con.Open();
            SqlCommand cmd = new SqlCommand(d, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (s1 == reader["Username"].ToString() && s2 == reader["Password"].ToString())
                {
                    Session["Uid"] = reader["Id"];
                    if ((bool)reader["User_Type"] == true)
                    {
                        Session["Salutation"] = "User";
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Session["Salutation"] = "Admin";
                        Response.Redirect("WebForm5.aspx");
                    }
                }


            }
            con.Close();
        }

        protected void Back_Home_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm1.aspx");
        }
    }
}