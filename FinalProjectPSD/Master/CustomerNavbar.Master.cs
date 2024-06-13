using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Master
{
    public partial class CustomerNavbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void orderBtn_click(object sender, EventArgs e)
        {

        }

        protected void historyBtn_click(object sender, EventArgs e)
        {

        }

        protected void profileBtn_click(object sender, EventArgs e)
        {

        }

        protected void logoutBtn_click(object sender, EventArgs e)
        {
            Session.Remove("user");
            if (Request.Cookies["user_cookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["user_cookie"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("~/View/Guest/LoginPage.aspx");
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {

        }

        protected void OrderQBtn_Click(object sender, EventArgs e)
        {

        }

        protected void ReportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}