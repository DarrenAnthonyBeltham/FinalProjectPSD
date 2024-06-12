using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class CartHandler
    {
        CartRepository cartRepo = new CartRepository();

        public int getIDFromUsername(string x)
        {
            int id = cartRepo.getIDFromUsername(x);
            return id;
        }

        public List<Cart> showCartList(int id)
        {
            return cartRepo.getCart(id);
        }

        public void deleteCart(int id)
        {
            cartRepo.deleteCart(id);
        }

        public void checkout(int id)
        {
            cartRepo.checkout(id);
        }  

        public void addCart(int userID, int makeupID, int qty)
        {
            cartRepo.addCart(userID, makeupID, qty);
        }
    }
}