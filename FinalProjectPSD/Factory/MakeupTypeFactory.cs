using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class MakeupTypeFactory
    {
        public static MakeupType create(int id, String name)
        {
            MakeupType makeuptype = new MakeupType()
            {
                MakeupTypeID = id,
                MakeupTypeName = name
            };
            return makeuptype;
        }
    }
}