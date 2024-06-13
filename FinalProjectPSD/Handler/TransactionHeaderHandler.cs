using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class TransactionHeaderHandler
    {
        public static TransactionHeaderRepository repo = new TransactionHeaderRepository();
        public static List<TransactionHeader> getAll()
        {
            return repo.getAll();
        }

        public static void update(int id)
        {
            repo.update(id);
        }
    }
}