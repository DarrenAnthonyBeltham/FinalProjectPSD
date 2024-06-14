using FinalProjectPSD.Model;
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
            //master load pertama kali, validasi pembuatan sesi di login

            //if (!IsPostBack)
            //{
                if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/View/Guest/LoginPage.aspx");
                }
                else if (Request.Cookies["user_cookie"] != null && Session["user"] == null)
                {
                    Response.Redirect("~/View/Guest/LoginPage.aspx");
                }
            //}

            User user = (User)Session["user"];
            String role = user.UserRole;

            if (role.Equals("customer"))
            {
                orderBtn.Visible = true;
                historyBtn.Visible = true;
                profileBtn.Visible = true;
                logoutBtn.Visible = true;
                HomeBtn.Visible = false;
                ManageBtn.Visible = false;
                OrderQBtn.Visible = false;
                ReportBtn.Visible = false;
            }
            else
            {
                orderBtn.Visible = false;
                historyBtn.Visible = true;
                profileBtn.Visible = true;
                logoutBtn.Visible = true;
                HomeBtn.Visible = true;
                ManageBtn.Visible = true;
                OrderQBtn.Visible = true;
                ReportBtn.Visible = true;
            }
        }
        protected void orderBtn_click(object sender, EventArgs e)
        {

            Response.Redirect("~/View/Customer/OrderMakeUp.aspx");
        }

        protected void historyBtn_click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionHistory.aspx");
        }

        protected void profileBtn_click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customer/ProfilePage.aspx");
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
            Response.Redirect("~/View/Homepage.aspx");
        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/ManageMakeup.aspx");
        }

        protected void OrderQBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/HandleTransaction.aspx");
        }

        protected void ReportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}