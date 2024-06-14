using FinalProjectPSD.Controller;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        String role = "";
        public List<TransactionHeader> thlist = new List<TransactionHeader>();
        TransactionHeaderController thcontroller = new TransactionHeaderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            //anggapannya mereka ke page yg ada master, udh pasti ada sesi
            //ngecek sesi customer / admin
            //User user = (User)Session["user"];
            //Label1.Text = user.UserRole;
            //role = user.UserRole;
            if (Session["user"] != null)
            {
                User user = (User)Session["user"];
                role = user.UserRole;
            }

            if (role.Equals("customer"))
            {
                //get transactions by id
                thlist = thcontroller.getByID(Convert.ToInt32(Request.Cookies["user_cookie"].Value));
            }
            //admin
            else
            {
                thlist = thcontroller.getAll();
            }
        }
    }
}