using FinalProjectPSD.Controller;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Admin
{
    public partial class UpdateMakeupBrand : System.Web.UI.Page
    {
        int makeupId;
        MakeupBrandController mbController = new MakeupBrandController();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session nya sini
            makeupId = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                Lbl_error.Text = makeupId.ToString();
                MakeupBrand mb = mbController.getMakeupBrand(makeupId);

                TextBox1.Text = mb.MakeupBrandName;
                TextBox2.Text = mb.MakeupBrandRating.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String brand = TextBox1.Text;
            String rating = TextBox2.Text;

            Lbl_error.Text = mbController.validateBrand(brand, rating);

            if (Lbl_error.Text.Equals(""))
            {
                mbController.updateMakeUpBrand(makeupId, brand, Convert.ToInt32(rating));
                Response.Redirect("~/View/Admin/ManageMakeup.aspx");
            }
        }
    }
}