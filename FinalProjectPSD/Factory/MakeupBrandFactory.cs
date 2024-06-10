using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class MakeupBrandFactory
    {
        public static MakeupBrand create(int id, string name, int rating)
        {
            MakeupBrand makeUpBrand = new MakeupBrand()
            {
                MakeupBrandID = id,
                MakeupBrandName = name,
                MakeupBrandRating = rating
            };
            return makeUpBrand;
        }
    }
}