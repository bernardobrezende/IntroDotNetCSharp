using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TweetBeer.Web
{
    public partial class FavoriteBeers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["S"] = "Test";
            ViewState["S1"] = "Test2";
            ViewState["S3"] = "Test3";
            ViewState["S4"] = "Test4";
        }

        protected void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            string v = ViewState["S"] as string;

            ListItem selectedBeer = this.ucBeerList.SelectedBeer;
            if (selectedBeer != null)
            {
                this.lbFavorites.Items.Add(new ListItem(selectedBeer.Text));
            }
            // Cleaning up Beer List
            this.ucBeerList.RemoveSelectedBeer();
        }
    }
}