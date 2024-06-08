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

        public void insertMakeUpBrand(int id, string name, int rating)
        {
            MakeupBrand makeUpBrand = MakeupBrandFactory.create(id, name, rating);
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
    }
}