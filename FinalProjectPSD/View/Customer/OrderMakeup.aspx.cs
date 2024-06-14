using FinalProjectPSD.Controller;
using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Customer
{
    public partial class OrderMakeup : System.Web.UI.Page
    {

        public List<Makeup> makeups = null;
        public List<Cart> carts = null;
        CartController controller = new CartController();
        MakeupController makeupController = new MakeupController();
        string x = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];
            if (cookie == null) Response.Redirect("/View/Guest/LoginPage.aspx");
            x = cookie.Value;

            controller.showCartList (x);
            cartList.DataSource = carts;
            cartList.DataBind();
            makeupController.showMakeupList();
            makeupList.DataSource = makeups;
            makeupList.DataBind();
        }

        protected void makeupList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Order")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = makeupList.Rows[index-1];
                int makeupID = Convert.ToInt32(row.Cells[0].Text);
                TextBox quantity = (TextBox)row.FindControl("QuantityTB");
                int qty = Convert.ToInt32(quantity.Text);

                if(qty > 0)
                {
                    int userID = controller.getUserID(x);
                    controller.addCart(userID, makeupID, qty);
                    carts = controller.showCartList(x);
                    cartList.DataSource = carts;
                    cartList.DataBind();
                }
                else
                {
                    cartLbl.Text = "Quantity must be more than 0";
                }
            }
        }

        protected void clearBtn_Click(object sender, EventArgs e)
        {
            int q = controller.getUserID(x);
            controller.deleteCart(q);
            carts = controller.showCartList(x);
            cartList.DataSource = carts;
            cartList.DataBind();
        }

        protected void checkoutBtn_Click(object sender, EventArgs e)
        {
            int q = controller.getUserID(x);
            controller.checkout(q);
            carts = controller.showCartList(x);

            ErrorLabel.Text = controller.cartListEmptyError(x);
            ErrorLabel.ForeColor = Color.Red;

            cartList.DataSource = carts;
            cartList.DataBind();
        }
    }
}