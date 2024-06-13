using FinalProjectPSD.Factory;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class MakeupBrandRepository
    {
        public MakeUpzzEntities1 db = DataSingleton.getInstance();

        public int getId()
        {
            int newID;
            int id = (from x in db.MakeupBrands select x.MakeupBrandID).ToList().LastOrDefault();

            if (id == 0)
            {
                newID = 1;
            }
            else
            {
                newID = id + 1;
            }
            return newID;
        }
        public void insertMakeUpBrand(string name, int rating)
        {
            MakeupBrand makeUpBrand = MakeupBrandFactory.create(getId(), name, rating);
            db.MakeupBrands.Add(makeUpBrand);
            db.SaveChanges();
        }

        public void deleteMakeUpBrand(int id)
        {
            MakeupBrand makeUpBrand = db.MakeupBrands.Find(id);
            if (makeUpBrand != null)
            {
                db.MakeupBrands.Remove(makeUpBrand);
                db.SaveChanges();
            }
        }

        public void updateMakeUpBrand(int id, string name, int rating)
        {
            MakeupBrand makeUpBrand = db.MakeupBrands.Find(id);

            if (makeUpBrand != null)
            {
                makeUpBrand.MakeupBrandID = id;
                makeUpBrand.MakeupBrandName = name;
                makeUpBrand.MakeupBrandRating = rating;

                db.SaveChanges();
            }
            else
            {
                throw new Exception("Make Up Brands not Found!");
            }
        }

        public List<MakeupBrand> getAllMakeupBrand()
        {
            return (from x in db.MakeupBrands select x).ToList();
        }

        public List<MakeupBrand> getAllMakeupBrandDescending()
        {
            return (from x in db.MakeupBrands orderby x.MakeupBrandRating descending select x).ToList();
        }

        public MakeupBrand getMakeupBrand(int id)
        {
            return (from x in db.MakeupBrands where x.MakeupBrandID == id select x).FirstOrDefault();
        }
    }
}