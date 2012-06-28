using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpEntityFramework.Web
{
    public partial class FavoriteBeers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddToFavorites_Click(object sender, EventArgs e)
        {
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