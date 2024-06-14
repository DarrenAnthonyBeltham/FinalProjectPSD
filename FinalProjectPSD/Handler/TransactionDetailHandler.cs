using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class TransactionDetailHandler
    {
        TransactionDetailRepository tdrepo = new TransactionDetailRepository();

        public List<TransactionDetail> getByTransactionID(int transactionID)
        {
            return tdrepo.getByTransactionID(transactionID);

        }
    }
}