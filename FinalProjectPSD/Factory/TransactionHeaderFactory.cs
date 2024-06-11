using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int transactionID, int userID, DateTime date, string status)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.TransactionID = transactionID;
            transactionHeader.UserID = userID;
            transactionHeader.TransactionDate = date;
            transactionHeader.Status = status;
            return transactionHeader;
        }
    }
}