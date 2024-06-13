using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class MakeupController
    {
        MakeupHandler handler = new MakeupHandler();
        MakeupRepository repository = new MakeupRepository();

        public List<Makeup> showMakeupList()
        {
            return repository.showMakeUp();
        }
    }
}