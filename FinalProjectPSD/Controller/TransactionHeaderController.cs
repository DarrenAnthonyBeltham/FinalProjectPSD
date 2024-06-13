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
        public static List<TransactionHeader> getAll()
        {
            return TransactionHeaderHandler.getAll();
        }

        public static void update(int id)
        {
            TransactionHeaderHandler.update(id);
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