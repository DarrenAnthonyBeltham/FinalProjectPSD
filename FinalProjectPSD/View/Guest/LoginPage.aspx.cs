using FinalProjectPSD.Controller;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Guest
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UserController uc = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = TB_name.Text;
            String password = TB_password.Text;
            Lbl_error.Text = uc.login(username, password, CB);
            if (Lbl_error.Text.Equals(""))
            {
                Response.Redirect("CustomerHome.aspx");
            }
        }
    }
}