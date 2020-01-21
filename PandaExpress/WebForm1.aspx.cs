using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PandaExpress
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RadioButtonList1.Items.Add("DAY");
                RadioButtonList1.Items.Add("NIGHT");
            } 
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            cookie = Request.Cookies["User_Themes"];
            if (cookie == null)
                cookie = new HttpCookie("User_Themes");
            else
                Page.Theme = cookie["User_Themes"];
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cookie["User_Themes"] = RadioButtonList1.SelectedValue;
            Response.Cookies.Add(cookie);
            cookie.Expires = DateTime.Now.AddYears(1);
            Response.Redirect("WebForm1.aspx");
        }
    }
}