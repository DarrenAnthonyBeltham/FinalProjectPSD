using FinalProjectPSD.Controller;
using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Admin
{
    public partial class InsertMakeupBrand : System.Web.UI.Page
    {
        string role = "";
        MakeupBrandController mbController = new MakeupBrandController();
        UserController uc = new UserController();
        UserHandler userHandler = new UserHandler();
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
                    user = userHandler.userbyid(userId);
                    Session["user"] = user;
                }
                // Kondisi saat login, tapi tidak ada cookie
                else
                {
                    user = (User)Session["user"];
                }
                role = user.UserRole;
            }

            if (role.Equals("customer"))
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String brand = TextBox1.Text;
            String rating = TextBox2.Text;

            Lbl_error.Text = mbController.validateBrand(brand, rating);

            if (Lbl_error.Text.Equals(""))
            {
                mbController.insertMakeUpBrand(brand, Convert.ToInt32(rating));
                Response.Redirect("~/View/Admin/ManageMakeup.aspx");
            }
        }
    }
}