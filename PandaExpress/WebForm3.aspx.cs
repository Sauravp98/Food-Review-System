using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


namespace PandaExpress
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RadioButtonList1.Items.Add("Admin");
                RadioButtonList1.Items.Add("User");
            }
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if (cookie != null)
                Page.Theme = cookie["User_Themes"];
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("INSERT INTO UserDetails (Username, User_Type, Password, Name, Mobile, EmailID) VALUES (@m1, @ut, @m2, @m3, @m4, @m5)", con);
            cmd.Parameters.AddWithValue("@m1", tb1.Text);
            cmd.Parameters.AddWithValue("@m2", tb2.Text);
            cmd.Parameters.AddWithValue("@m3", tb3.Text);
            cmd.Parameters.AddWithValue("@m4", tb4.Text);
            cmd.Parameters.AddWithValue("@m5", tb5.Text);
            cmd.Parameters.AddWithValue("@ut", RadioButtonList1.SelectedIndex);
            con.Open();
            int y = cmd.ExecuteNonQuery();
            con.Close();
            Server.Transfer("WebForm2.aspx");
        }

        protected void CustomValidator1_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            string g = tb4.Text;
            if (!Regex.IsMatch(g, "[0-9]{10}"))
                args.IsValid = false;
        }

        protected void Back_Home_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm1.aspx");
        }
    }
}