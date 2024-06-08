using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class DataSingleton
    {
        private static MakeUpzzEntities1 db = null;

        public static MakeUpzzEntities1 getInstance()
        {
            if (db == null)
            {
                db = new MakeUpzzEntities1();
            }
            return db;
        }
    }
}