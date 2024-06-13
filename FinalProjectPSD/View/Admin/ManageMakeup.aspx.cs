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
    public partial class ManageMakeup : System.Web.UI.Page
    {
        public String role = "";
        public List<Makeup> makeupList = new List<Makeup>();
        public List<MakeupType> makeupTypeList = new List<MakeupType>();
        public List<MakeupBrand> makeupBrandList = new List<MakeupBrand>();
        UserController uc = new UserController();
        MakeupBrandController mbController = new MakeupBrandController();
        MakeupController makeupController = new MakeupController();
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

            makeupList = makeupController.showMakeupList();
            makeupBrandList = mbController.getAllMakeupBrandDescending();

            if (!IsPostBack)
            {
                GV_Brand.DataSource = makeupBrandList;
                GV_Brand.DataBind();
            }
        }

        protected void GV_Brand_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GV_Brand.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            label_error.Text = mbController.cekBrand(id);

            if (label_error.Text.Equals(""))
            {
                mbController.deleteMakeUpBrand(id);
                Response.Redirect("ManageMakeup.aspx");
            }
        }

        protected void GV_Brand_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = GV_Brand.Rows[e.NewSelectedIndex];
            String id = row.Cells[0].Text;
            Response.Redirect("~/View/Admin/UpdateMakeupBrand.aspx?id=" + id);
        }

        protected void button_insertBrand_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/InsertMakeupBrand.aspx");
        }
    }
}