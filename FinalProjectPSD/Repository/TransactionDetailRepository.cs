using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class TransactionDetailRepository
    {
        static MakeUpzzEntities1 db = new MakeUpzzEntities1();

        public List<TransactionDetail> getByTransactionID(int transactionID)
        {
            return db.TransactionDetails.Where(TransactionDetail => TransactionDetail.TransactionID == transactionID).ToList();

        }
    }
}