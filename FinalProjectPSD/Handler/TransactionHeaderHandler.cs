using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class TransactionHeaderHandler
    {
        public TransactionHeaderRepository repo = new TransactionHeaderRepository();
        public List<TransactionHeader> getAll()
        {
            return repo.getAll();
        }
        public List<TransactionHeader> getByID(int id)
        {
            return repo.getByID(id);
        }

        public void update(int id)
        {
            repo.update(id);
        }
    }
}