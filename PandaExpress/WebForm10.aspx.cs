using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace PandaExpress
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        DataTable ds = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "Welcome " + Session["Salutation"];
            if (!IsPostBack)
            {
                RadioButtonList1.Items.Add(">=1");
                RadioButtonList1.Items.Add(">=2");
                RadioButtonList1.Items.Add(">=3");
                RadioButtonList1.Items.Add(">=4");
                CheckBoxList1.Items.Add("Manipal");
                CheckBoxList1.Items.Add("Mumbai");
                CheckBoxList1.Items.Add("Bangalore");
                CheckBoxList1.Items.Add("Delhi");
                CheckBoxList2.Items.Add("Indian");
                CheckBoxList2.Items.Add("American");
                CheckBoxList2.Items.Add("Continental");
                CheckBoxList2.Items.Add("Chinese");
            }
        }
        private const string ASCENDING = " ASC";
        private const string DESCENDING = " DESC";


        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = RadioButtonList1.SelectedValue;
            List<string> v1 = CheckBoxList1.Items.Cast<ListItem>().Where(li => li.Selected).Select(li => li.Value).ToList();
            List<string> v2 = CheckBoxList2.Items.Cast<ListItem>().Where(li => li.Selected).Select(li => li.Value).ToList();
            //v1 = v1.Concat(v2).ToList();
            string query;
            if (v1.Count == 0 && v2.Count == 0 && x=="")
                query = "SELECT * from HOTEL";
            else
            {
                query = "SELECT * from HOTEL WHERE ";
                if (v1.Count != 0)
                {
                    for (int i = 0; i < v1.Count - 1; i++)
                    {
                        query += "[Location] = '" + v1[i] + "' OR ";
                    }
                    query += "[Location] = '" + v1[v1.Count - 1] + "'";
                }
                if (v2.Count != 0)
                {
                    if (v1.Count != 0)
                        query += " AND ";
                    for (int i = 0; i < v2.Count - 1; i++)
                    {
                        query += "[Cuisine] = '" + v2[i] + "' OR ";
                    }
                    query += "[Cuisine] = '" + v2[v2.Count - 1] + "'";
                }
                if (x != "")
                {
                    if (v1.Count() + v2.Count() != 0)
                        query += " AND [Rating] " + x;
                    else
                        query += " [Rating] " + x;
                }
            }
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=abcd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            ViewState["pla"] = ds;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        public SortDirection GridViewSortDirection
        {
            get
            {
                if (ViewState["sortDirection"] == null)
                    ViewState["sortDirection"] = SortDirection.Ascending;
                return (SortDirection)ViewState["sortDirection"];
            }
            set { ViewState["sortDirection"] = value; }
        }
        private void SortGridView(string sortExpression, string direction)
        {
            //  You can cache the DataTable for improving performance
            DataTable dt = (DataTable)ViewState["pla"];
            
            DataView dv = new DataView(dt);
            dv.Sort = sortExpression + direction;

            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_Themes"];
            if (cookie != null)
                Page.Theme = cookie["User_Themes"];
        }
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortExpression = e.SortExpression;

            if (GridViewSortDirection == SortDirection.Ascending)
            {
                GridViewSortDirection = SortDirection.Descending;
                SortGridView(sortExpression, DESCENDING);
            }
            else
            {
                GridViewSortDirection = SortDirection.Ascending;
                SortGridView(sortExpression, ASCENDING);
            }
        }
    }
}

