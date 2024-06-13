using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class CartController
    {
        private CartHandler handler = new CartHandler();

        public int getUserID(string x)
        {
            int id = handler.getIDFromUsername(x);
            return id;
        }

        public List<Cart> showCartList(string x)
        {
            int id = handler.getIDFromUsername(x);
            return handler.showCartList(id);
        }

        public void deleteCart(int id)
        {
            handler.deleteCart(id);
        }

        public void checkout(int id)
        {
            handler.checkout(id);
        }

        public void addCart(int userID, int makeupID, int qty)
        {
            handler.addCart(userID, makeupID, qty);
        }

        public string cartListEmptyError(string x)
        {

            return showCartList(x).Count == 0 ? "No items in your shopping cart!" : "";
        }
    }
}