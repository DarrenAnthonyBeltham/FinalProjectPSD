using FinalProjectPSD.Factory;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class CartRepository
    {
        MakeUpzzEntities1 db = new MakeUpzzEntities1();

        public List<Cart> getCart(int id)
        {
            return db.Carts.Where(c => c.UserID == id).ToList();
        }

        protected int getLastID()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }

        protected int generateID()
        {
            int id = getLastID();
            if (db == null)
            {
                id = 1;
            }
            else
            {
                id = id + 1;
            }
            return id;
        }

        public void addCart(int userID, int makeupID, int quantity)
        {
            int cartID = generateID();
            Cart cart = CartFactory.Create(cartID, userID, makeupID, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public void deleteCart(int userID)
        {
            var cartItems = getCart(userID);
            db.Carts.RemoveRange(cartItems);
            db.SaveChanges();
        }

        protected int getLastTransactionHeaderID()
        {
            return (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
        }

        protected int generateTransactionHeaderID()
        {
            int id = getLastTransactionHeaderID();
            if(db == null)
            {
                id = 1;
            }
            else
            {
                id = id + 1;
            }
            return id;
        }

        public void checkout(int userID)
        {
            var items = getCart(userID);

            if(items == null || !items.Any())
            {
                throw new InvalidOperationException("No items in your shopping cart!");
            }

            int transactionHeaderID = generateTransactionHeaderID();
            TransactionHeader th = TransactionHeaderFactory.Create(transactionHeaderID, userID, DateTime.Today, "unhandled");
            db.TransactionHeaders.Add(th);
            db.SaveChanges();

            foreach (var item in items)
            {
                var existingItem = db.TransactionDetails.FirstOrDefault(td => td.TransactionID == th.TransactionID && td.MakeupID == item.MakeupID);

                if(existingItem == null)
                {
                    TransactionDetail transactionDetail = TransactionDetailFactory.Create(th.TransactionID, item.MakeupID, item.Quantity);
                    db.TransactionDetails.Add(transactionDetail);
                    db.SaveChanges();
                }
                else
                {
                    existingItem.Quantity += item.Quantity;
                    db.Entry(existingItem).State = EntityState.Modified;
                }
            }
            deleteCart(userID);
        }
    }
}