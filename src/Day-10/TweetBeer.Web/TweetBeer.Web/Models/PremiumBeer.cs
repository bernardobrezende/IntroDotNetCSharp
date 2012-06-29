namespace TweetBeer.Web.Models
{
    public partial class PremiumBeer
    {
        public override bool HasAlcohol
        {
            get
            {
                return this.Name != "Kronanbier";                
            }
            set { }
        }
    }
}