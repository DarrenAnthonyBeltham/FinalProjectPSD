using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class MakeupHandler
    {
        MakeupRepository makeupRepo = new MakeupRepository();

        public List<Makeup> showMakeupList()
        {
            return makeupRepo.showMakeUp();
        }
    }
}