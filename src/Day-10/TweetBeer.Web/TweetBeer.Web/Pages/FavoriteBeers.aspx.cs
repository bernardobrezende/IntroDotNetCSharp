using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TweetBeer.Web.Models;

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

            using (TweetBeerContainer tbContainer = new TweetBeerContainer())
            {
                var favoriteList = tbContainer.FavoriteBeerSet.ToList();
                foreach (FavoriteBeer fvBeer in favoriteList)
                {
                    this.lbFavorites.Items.Add(new ListItem(fvBeer.Beer.Name, fvBeer.Beer.Id.ToString()));
                }
            }
        }

        protected void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            string v = ViewState["S"] as string;

            ListItem selectedBeer = this.ucBeerList.SelectedBeer;
            if (selectedBeer != null)
            {
                this.lbFavorites.Items.Add(new ListItem(selectedBeer.Text));

                #region Adding in Database

                using (TweetBeerContainer tweetBeerContainer = new TweetBeerContainer())
                {
                    long id = Int64.Parse(selectedBeer.Value);
                    Beer currentBeer = tweetBeerContainer.Beer
                        .Single(b => b.Id == id);

                    FavoriteBeer favoriteBeer = new FavoriteBeer();                    
                    favoriteBeer.Beer = currentBeer;
                    favoriteBeer.CreationDate = DateTime.Now;
                    favoriteBeer.User = Session["userName"] as string;

                    tweetBeerContainer.AddToFavoriteBeerSet(favoriteBeer);
                    tweetBeerContainer.SaveChanges();
                }

                #endregion
            }
            // Cleaning up Beer List
            this.ucBeerList.RemoveSelectedBeer();
        }
    }
}