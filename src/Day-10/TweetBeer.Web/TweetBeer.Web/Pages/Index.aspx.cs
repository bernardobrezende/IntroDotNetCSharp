using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TweetBeer.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSetUser_Click(object sender, EventArgs e)
        {
            Session["userName"] = this.txtUserName.Text;
            //Session.Abandon();
            //Session.Clear();
        }
    }
}