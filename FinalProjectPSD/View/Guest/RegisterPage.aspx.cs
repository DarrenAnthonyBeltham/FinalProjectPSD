using FinalProjectPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Guest
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        UserController uc = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = TB_name.Text;
            String email = TB_email.Text;
            RadioButton male = rbMale;
            RadioButton female = rbFemale;
            String password = reg_password.Text;
            String confpassword = reg_confpass.Text;
            DateTime dob = Calendar.SelectedDate;
            reg_errorlbl.Text = uc.register(username, email, male, female, password, confpassword, dob);

            if (reg_errorlbl.Text.Equals(""))
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}