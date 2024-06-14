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
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        public List<TransactionDetail> tdlist = new List<TransactionDetail>();
        TransactionDetailController tdcontroller = new TransactionDetailController();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            tdlist = tdcontroller.getByTransactionID(id);
        }
    }
}