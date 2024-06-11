using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int transactionID, int makeupID, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = transactionID;
            transactionDetail.MakeupID = makeupID;
            transactionDetail.Quantity = quantity;
            return transactionDetail;
        }
    }
}