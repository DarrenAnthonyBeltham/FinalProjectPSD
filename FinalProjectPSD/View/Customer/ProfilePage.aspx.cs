using FinalProjectPSD.Controller;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Customer
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        UserController uc = new UserController();

        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/Guest/LoginPage.aspx");
            }
            else
            {
                User user = new User();
                if (Session["user"] == null)
                {
                    int userId = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = uc.GetUserbyID(userId);
                    Session["user"] = user;
                }
                else
                {
                    user = (User)Session["user"];
                }

                id = user.UserID;

                if (!IsPostBack)
                {
                    tbName.Text = user.Username;
                    tbEmail.Text = user.UserEmail;

                    if (user.UserGender.Equals("male"))
                    {
                        RBtn_Male.Checked = true;
                    }
                    else
                    {
                        RBtn_Female.Checked = true;
                    }
                    Calendar.SelectedDate = (DateTime)user.UserDOB;
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String username = tbName.Text;
            String email = tbEmail.Text;
            RadioButton male = RBtn_Male;
            RadioButton female = RBtn_Female;
            DateTime dob = Calendar.SelectedDate;
            string gender = "";

            int count = 0;

            uc.deleteName(id);

            lblErrorName.Text = uc.CheckUsername(username);
            if (lblErrorName.Text.Equals("")) count++;

            lblErrorEmail.Text = uc.checkEmail(email);
            if (lblErrorEmail.Text.Equals("")) count++;

            lblErrorGender.Text = uc.valdateGender(male, female, ref gender);
            if (lblErrorGender.Text.Equals("")) count++;

            lblErrorDOB.Text = uc.checkDOB(dob);
            if (lblErrorDOB.Text.Equals("")) count++;

            if (count == 4)
            {
                uc.updateProfile(id, username, email, gender, dob);
                lblSuccessProfile.Text = "Profile updated successfully";
            }
        }

        protected void btnUpdatePass_Click(object sender, EventArgs e)
        {
            String oldPass = tbOldPass.Text;
            String newPass = tbNewPass.Text;

            lblErrorOldPass.Text = uc.ValidateOldPassword(id, oldPass);

            if (lblErrorOldPass.Text.Equals(""))
            {
                uc.UpdateUserPassword(id, newPass);
                lblSuccessPass.Text = "Password updated successfully";
            }
        }

    }
}