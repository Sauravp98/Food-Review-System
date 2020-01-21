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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome " + Session["Salutation"];
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Search By Name");
                DropDownList1.Items.Add("Search By Cuisine");
                DropDownList1.Items.Add("Search By Rating");
                DropDownList1.Items.Add("Search By Location");
            }
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if (cookie != null)
                Page.Theme = cookie["User_Themes"];
        }
        protected void goto_click(object sender, GridViewCommandEventArgs e)// 
        {
            if (e.CommandName == "chalo")
            { 
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                int rid = Convert.ToInt32(selectedRow.Cells[0].Text);
                //TableCell contactName = selectedRow.Cells[1].Text;
                //string chosen_restaurant =;
                //Update count
                string s1 = selectedRow.Cells[1].Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
                string update_view_query = "UPDATE HOTEL SET [Views] = [Views]+1 WHERE NAME = @name AND Id = @id;";
                SqlCommand cmdViewUp = new SqlCommand(update_view_query, con);
                cmdViewUp.Parameters.AddWithValue("@name", s1);
                cmdViewUp.Parameters.AddWithValue("@id",rid);
                Application.Lock();
                con.Open();
                cmdViewUp.ExecuteNonQuery();
                con.Close();
                Application.UnLock();
                Response.Redirect("WebForm6.aspx?name=" + selectedRow.Cells[1].Text+"&rid="+rid);

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            con.Open();
            string d1 = "Select * from HOTEL where name=@name";
            string d2 = "Select * from HOTEL where cuisine=@cuisine";
            string d3 = "Select * from HOTEL where rating=@rating";
            string d4 = "Select * from HOTEL where location=@location";
            string d;
            //TextBox2.Text = DropDownList1.SelectedItem.Text;
            SqlCommand cmd;
            if (DropDownList1.SelectedItem.Text == "Search By Name")
            {
                d = d1;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            }
            else if (DropDownList1.SelectedItem.Text == "Search By Cuisine")
            {
                d = d2;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@cuisine", TextBox1.Text);
            }
            else if (DropDownList1.SelectedItem.Text == "Search By Rating")
            {
                d = d3;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@rating", TextBox1.Text);
            }
            else
            {
                d = d4;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@location", TextBox1.Text);
            }
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "HOTEL");
            con.Close();
            d = "";
            GridView1.DataSource = ds;
            GridView1.DataBind();
            //Server.Transfer("WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Salutation"] = null;
            Session["Uid"] = null;
            Response.Redirect("WebForm1.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True";
            con.Open();
            string d1 = "Select * from HOTEL where name=@name";
            string d2 = "Select * from HOTEL where cuisine=@cuisine";
            string d3 = "Select * from HOTEL where rating=@rating";
            string d4 = "Select * from HOTEL where location=@location";
            string d;
            //TextBox2.Text = DropDownList1.SelectedItem.Text;
            SqlCommand cmd;
            if (DropDownList1.SelectedItem.Text == "Search By Name")
            {
                d = d1;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            }
            else if (DropDownList1.SelectedItem.Text == "Search By Cuisine")
            {
                d = d2;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@cuisine", TextBox1.Text);
            }
            else if (DropDownList1.SelectedItem.Text == "Search By Rating")
            {
                d = d3;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@rating", TextBox1.Text);
            }
            else
            {
                d = d4;
                cmd = new SqlCommand(d, con);
                cmd.Parameters.AddWithValue("@location", TextBox1.Text);
            }
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "HOTEL");
            con.Close();
            d = "";
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}