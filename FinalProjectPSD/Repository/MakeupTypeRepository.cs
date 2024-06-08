using FinalProjectPSD.Factory;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class MakeupTypeRepository
    {
        public MakeUpzzEntities1 db = DataSingleton.getInstance();

        public void insertMakeUpType(int id, string name)
        {
            MakeupType makeuptype = MakeupTypeFactory.create(id, name);
            db.MakeupTypes.Add(makeuptype);
            db.SaveChanges();
        }

        public Boolean checkType(int type)
        {
            string typeAsString = type.ToString();

            foreach (var x in db.MakeupTypes)
            {
                if (x.MakeupTypeName == typeAsString)
                {
                    return true;
                }
            }
            return false;
        }

        public void deleteMakeUpType(int id)
        {
            MakeupType makeUpType = db.MakeupTypes.Find(id);

            if (makeUpType != null)
            {
                db.MakeupTypes.Remove(makeUpType);
                db.SaveChanges();
            }
        }

        public void updateMakeUpType(int id, string name)
        {
            MakeupType makeUpType = db.MakeupTypes.Find(id);

            if (makeUpType != null)
            {
                makeUpType.MakeupTypeName = name;
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Make Up Type not Found!");
            }
        }

        public int getIdbyType(int type)
        {
            return (from x in db.MakeupTypes where x.MakeupTypeName.Equals(type) select x.MakeupTypeID).LastOrDefault();
        }

        public int generateId()
        {
            Random random = new Random();
            int randomNumber = random.Next(101);
            return randomNumber;
        }
    }
}