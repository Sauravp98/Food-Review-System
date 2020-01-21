using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PandaExpress
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "/Images/delicious-hamburger-and-food-truck.jpg";

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Salutation"] == null)
                Response.Redirect("WebForm1.aspx");
            else if (Session["Salutation"].ToString().Equals("Admin"))
                Response.Redirect("WebForm5.aspx");
            else if (Session["Salutation"].ToString().Equals("User"))
                Response.Redirect("WebForm4.aspx");
        }
    }
}