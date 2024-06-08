using FinalProjectPSD.Factory;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class MakeupRepository
    {
        public MakeUpzzEntities1 db = DataSingleton.getInstance();

        public List<Makeup> showMakeUp()
        {
            return (from x in db.Makeups select x).ToList();
        }

        public void insertMakeUp(int id, string name, int price, int weight, int typeid, int brandid)
        {
            Makeup makeUp = MakeupFactory.create(id, name, price, weight, typeid, brandid);
            db.Makeups.Add(makeUp);
            db.SaveChanges();
        }

        public void deleteMakeUp(int id)
        {
            Makeup makeup = db.Makeups.Find(id);
            if (makeup != null)
            {
                db.Makeups.Remove(makeup);
                db.SaveChanges();
            }
        }

        public void updateMakeUp(int id, string name, int price, int weight, int typeid, int brandid)
        {
            Makeup makeup = db.Makeups.Find(id);

            if (makeup != null)
            {
                makeup.MakeupName = name;
                makeup.MakeupPrice = price;
                makeup.MakeupWeight = weight;
                makeup.MakeupTypeID = typeid;
                makeup.MakeupBrandID = brandid;

                db.SaveChanges();
            }
            else
            {
                throw new Exception("Make Up Not Found!");
            }
        }

        public int generateId()
        {
            Random random = new Random();
            int randomNumber = random.Next(101);
            return randomNumber;
        }
    }
}