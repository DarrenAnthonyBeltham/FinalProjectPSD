using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class TransactionHeaderController
    {
        TransactionHeaderHandler thhandler = new TransactionHeaderHandler();
        public List<TransactionHeader> getAll()
        {
            return thhandler.getAll();
        }
        public List<TransactionHeader> getByID(int id)
        {
            return thhandler.getByID(id);
        }

        public void update(int id)
        {
            thhandler.update(id);
        }

        public static String validateStatus(String status)
        {
            if (status.Equals("handled"))
            {
                return "Transaction has been handled";
            }
            return "";
        }
    }
}