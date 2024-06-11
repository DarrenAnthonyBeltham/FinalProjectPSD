using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class CartFactory
    {
        public static Cart Create(int cartID, int userID, int makeupID, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = cartID;
            cart.UserID = userID;   
            cart.MakeupID = makeupID;
            cart.Quantity = quantity;
            return cart;
        }
    }
}