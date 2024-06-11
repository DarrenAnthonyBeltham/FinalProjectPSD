using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Customer
{
    public partial class OrderMakeup : System.Web.UI.Page
    {

        public List<Makeup> makeups = null;
        public List<Cart> carts = null;
        UserRepository repo= new UserRepository();
        MakeupRepository makeupRepo = new MakeupRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
    }
}