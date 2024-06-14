using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class TransactionDetailController
    {
        TransactionDetailHandler tdhandler = new TransactionDetailHandler();

        public List<TransactionDetail> getByTransactionID(int transactionID)
        {
            return tdhandler.getByTransactionID(transactionID);
        }
    }
}