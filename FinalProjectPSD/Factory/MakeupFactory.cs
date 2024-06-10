using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class MakeupFactory
    {
        public static Makeup create(int id, string name, int price, int weight, int typeid, int brandid)
        {
            Makeup makeup = new Makeup()
            {
                MakeupID = id,
                MakeupName = name,
                MakeupPrice = price,
                MakeupWeight = weight,
                MakeupTypeID = typeid,
                MakeupBrandID = brandid
            };
            return makeup;
        }
    }
}