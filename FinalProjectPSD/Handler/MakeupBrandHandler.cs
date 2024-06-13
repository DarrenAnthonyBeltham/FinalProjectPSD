using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class MakeupBrandHandler
    {
        MakeupBrandRepository repo = new MakeupBrandRepository();
        public void insertMakeUpBrand(string name, int rating)
        {
            repo.insertMakeUpBrand(name, rating);
        }

        public void deleteMakeUpBrand(int id)
        {
            repo.deleteMakeUpBrand(id);
        }

        public void updateMakeUpBrand(int id, string name, int rating)
        {
            repo.updateMakeUpBrand(id, name, rating);
        }

        public List<MakeupBrand> getAllMakeupBrand()
        {
            return repo.getAllMakeupBrand();
        }

        public List<MakeupBrand> getAllMakeupBrandDescending()
        {
            return repo.getAllMakeupBrandDescending();
        }

        public MakeupBrand getMakeupBrand(int id)
        {
            return repo.getMakeupBrand(id);
        }
    }
}