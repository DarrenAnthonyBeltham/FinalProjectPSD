using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        UserRepository repo= new UserRepository();
        MakeupRepository makeupRepo = new MakeupRepository();
        CartRepository cartRepo = new CartRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private int getUserID()
        {
            string x = Session["Username"].ToString();
            int id = repo.getIDFromUsername(x);
            return id;
        }

        private void showMakeupList()
        {
            makeups = makeupRepo.showMakeUp();
            makeupList.DataSource = makeups;
            makeupList.DataBind();
        }
       
        private void showCartList()
        {
            int id = getUserID();
            carts = cartRepo.getCart(id);
            cartList.DataSource = carts;
            cartList.DataBind();
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
                    int userID = getUserID();
                    cartRepo.addCart(userID, makeupID, qty);
                    showCartList();
                }
                else
                {
                    cartLbl.Text = "Quantity must be more than 0";
                }
            }
        }

        protected void clearBtn_Click(object sender, EventArgs e)
        {
            int x = getUserID();
            cartRepo.deleteCart(x);
            showCartList();
        }

        protected void checkoutBtn_Click(object sender, EventArgs e)
        {
            int x = getUserID();
            cartRepo.checkout(x);
            showCartList();
        }
    }
}