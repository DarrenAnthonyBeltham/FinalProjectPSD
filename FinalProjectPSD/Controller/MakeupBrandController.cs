using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class MakeupBrandController
    {
        MakeupBrandHandler handler = new MakeupBrandHandler();
        MakeupController makeupController = new MakeupController();
        public void insertMakeUpBrand(string name, int rating)
        {
            handler.insertMakeUpBrand(name, rating);
        }

        public void deleteMakeUpBrand(int id)
        {
            handler.deleteMakeUpBrand(id);
        }

        public void updateMakeUpBrand(int id, string name, int rating)
        {
            handler.updateMakeUpBrand(id, name, rating);
        }

        public List<MakeupBrand> getAllMakeupBrand()
        {
            return handler.getAllMakeupBrand();
        }

        public List<MakeupBrand> getAllMakeupBrandDescending()
        {
            return handler.getAllMakeupBrandDescending();
        }

        public MakeupBrand getMakeupBrand(int id)
        {
            return handler.getMakeupBrand(id);
        }

        public String cekBrand(int id)
        {
            List<Makeup> list = makeupController.showMakeupList();

            foreach (Makeup makeup in list)
            {
                if (makeup.MakeupBrandID.Equals(id))
                {
                    return "Cannot be deleted!";
                }
            }
            return "";
        }

        public String validateBrand(String brand, String rating)
        {
            if (brand.Length < 1 || brand.Length > 99)
            {
                return "Makeup brand name must be 1-99 characters";
            }
            else if (rating.Equals(""))
            {
                return "Makeup brand rating cannot be empty";
            }
            else
            {
                int rate = Convert.ToInt32(rating);
                if (rate < 0 || rate > 100)
                {
                    return "Makeup brand rating must be 0-100";
                }
                else
                {
                    return "";
                }
            }
        }
    }
}