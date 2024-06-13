using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.View.Admin
{
    public partial class ViewCustomer : System.Web.UI.Page
    {
        UserRepository user = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<User> users = user.showUsers();
                userGridView.DataSource = users;
                userGridView.DataBind();
            }
        }
    }
}