using FinalProjectPSD.Controller;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Admin
{
    public partial class HandleTransaction : System.Web.UI.Page
    {
        public List<TransactionHeader> thList = new List<TransactionHeader>();
        TransactionHeaderController thcontroller = new TransactionHeaderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                thList = thcontroller.getAll();
                GV.DataSource = thList;
                GV.DataBind();
            }
        }

        protected void GV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument.ToString());
            GridViewRow rowIdx = GV.Rows[row];
            int transactionId = Convert.ToInt32(rowIdx.Cells[0].Text);
            String status = rowIdx.Cells[3].Text;

            Lbl_Error.Text = TransactionHeaderController.validateStatus(status);

            if (Lbl_Error.Text.Equals(""))
            {
                thcontroller.update(transactionId);
                Response.Redirect("~/View/Admin/HandleTransaction.aspx");
            }
        }
    }
}