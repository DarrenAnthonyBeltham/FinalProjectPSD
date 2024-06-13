using FinalProjectPSD.Model;
using FinalProjectPSD.Controller;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectPSD.Handler;

namespace FinalProjectPSD.View.Guest
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UserController uc = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];
            //berarti ada sesi yang lg berlangsung or ada cookie
            if (Session["user"] != null || cookie != null)
            {
                User user = (User)Session["user"];

                //ada cookie tapi gada session
                if (Session["user"] == null && cookie != null)
                {
                    int id = Convert.ToInt32(cookie["user_cookie"]);
                    user = uc.Checkuserbyid(id);
                    Session["user"] = user;
                }
                //gada cookie ada session
                else
                {
                    user = (User)Session["user"];
                }
                String role = user.UserRole;

                if (role == "customer")
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }
                else if (role == "admin")
                {
                    Response.Redirect("/View/HomePage.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = TB_name.Text;
            String password = TB_password.Text;
            CheckBox cb = CB;

            Lbl_error.Text = uc.login(username, password, cb);

            if (Lbl_error.Text.Equals(""))
            {
                Response.Redirect("/View/HomePage.aspx");
            }
        }
    }
}