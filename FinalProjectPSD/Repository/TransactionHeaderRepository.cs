using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class TransactionHeaderRepository
    {
        static MakeUpzzEntities1 db = DataSingleton.getInstance();

        public List<TransactionHeader> getAll()
        {
            return db.TransactionHeaders.ToList();
        }

        public List<TransactionHeader> getByID(int id)
        {
            return (from x in db.TransactionHeaders where x.UserID == id select x).ToList();
        }

        public TransactionHeader getByTransactionID(int transactionID)
        {
            return(from x in db.TransactionHeaders where x.TransactionID == transactionID select x).FirstOrDefault();
        }

        public void update(int id)
        {
            TransactionHeader x = getByTransactionID((id);
            x.Status = "handled";
            db.SaveChanges();
        }
    }
}