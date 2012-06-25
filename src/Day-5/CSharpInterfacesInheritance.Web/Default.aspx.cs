using System;
using CSharpInterfacesInheritance.Web.MyClasses;

namespace CSharpClasses.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Creating with optional parameters
            //Beer b3 = new Beer("Therezópolis", "Brasil");
            //Beer b4 = new Beer("Coruja");

            try
            {
                //Beer b5 = new Beer(null, "RS");
                //b5.Open();
            }
            catch { } // Never do this!!

            // Creating using type-initializer
            //Beer b6 = new Beer("Coruja")
            //{
            //    Weight = 456,
            //};
            //b6.Name = "";
            // Java Style:
            //b5.setWeight(456);

            PremiumBeer premium = new PremiumBeer("Muller");
            this.lblResult.Visible = true;
            this.lblResult.Text = premium.ToString();

            Beer muller = new PremiumBeer("Muller");
            this.lblResult.Text = muller.ToString();

            StoutBeer guinness = new StoutBeer("Guinness", 800);
            guinness.Open();
            guinness.Drink(400);

            if (guinness is PremiumBeer)
            {
                Response.Redirect("http://www.google.com");
            }
            else if (guinness is StoutBeer)
            {
                Response.Redirect("http://www.guinness.com", true);
            }
        }

        protected void btnOpenAndDrink_Click(object sender, EventArgs e)
        {
            // Creating beer
            //Beer createdBeer = new Beer(this.txtName.Text
            //    , "Brasil"
            //    , Convert.ToDouble(this.txtInitialWeight.Text));            
            // Opening beer
            //createdBeer.Open();
            //// Drinking the beer
            //double w = Convert.ToDouble(this.txtWeight.Text);
            //createdBeer.Drink(weight: w);

            // Consuming IEnumerable of errors
            //IEnumerable<string> errors = createdBeer.DrinkAndGetErrors(w);

            #region Displaying errors

            //if (createdBeer.Errors.Count > 0)
            //{
            //    StringBuilder errorBuilder = new StringBuilder();
            //    foreach (string error in createdBeer.Errors)
            //    {
            //        errorBuilder.AppendLine(error);
            //    }
            //    this.lblErrors.Visible = true;
            //    this.lblErrors.Text = errorBuilder.ToString();
            //}
            //else
            //{
            //    this.lblResult.Visible = true;
            //    this.lblResult.Text = "Drank with success! You can still drink more " + createdBeer.Weight + " ml";
            //}            

            #endregion
        }
    }
}
