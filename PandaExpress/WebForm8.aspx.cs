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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome " + Session["Salutation"];
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            string query = "Select * from Comments Where Status=0";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Comments");
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if (cookie != null)
                Page.Theme = cookie["User_Themes"];
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            string sx = "Update Comments SET [Status] = 1 where ID=@abc";
            string sy = "Delete FROM Comments Where ID=@abc";
            if (e.CommandName == "chalo")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                int cid = Convert.ToInt32(selectedRow.Cells[0].Text);
                SqlCommand cmd = new SqlCommand(sx, con);
                cmd.Parameters.AddWithValue("@abc", cid);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("WebForm8.aspx");
            }
            else if (e.CommandName == "niklo")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                int cid = Convert.ToInt32(selectedRow.Cells[0].Text);
                SqlCommand cmd = new SqlCommand(sy, con);
                cmd.Parameters.AddWithValue("@abc", cid);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                con.Close();
                Server.Transfer("WebForm8.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Salutation"] = null;
            Session["Uid"] = null;
            Response.Redirect("WebForm1.aspx");
        }
    }
}