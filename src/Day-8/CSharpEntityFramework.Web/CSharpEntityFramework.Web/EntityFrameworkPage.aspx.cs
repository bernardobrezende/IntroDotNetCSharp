using System;
using System.Linq;
using CSharpEntityFramework.Web.Models;

namespace CSharpEntityFramework.Web
{
    public partial class _EntityFrameworkPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Beer b = new PremiumBeer();
                b.Name = "Primator";
                b.Weight = b.InitialWeight = 645;
                b.Country = "CZECH";


                using (TweetBeerContainer dbContainer = new TweetBeerContainer())
                {
                    #region Inserting

                    dbContainer.AddToBeer(b);
                    dbContainer.SaveChanges();

                    #endregion

                    #region Updating

                    b.Name = "Corona";
                    dbContainer.SaveChanges();

                    #endregion

                    #region Delete

                    //dbContainer.DeleteObject(b);
                    //dbContainer.SaveChanges();

                    #endregion

                    #region LINQ Query

                    var coronas = from beer in dbContainer.Beer.ToList()
                                  where beer.Name == "Corona"
                                  select beer;                                  

                    #endregion
                }

                #region Equivalent to using

                //TweetBeerContainer v = null;
                //try
                //{
                //    v = new TweetBeerContainer();
                //    // Fazer um monte de coisa
                //}
                //catch
                //{
                //}
                //finally
                //{
                //    v.Dispose();
                //}

                #endregion
            }
        }
    }
}