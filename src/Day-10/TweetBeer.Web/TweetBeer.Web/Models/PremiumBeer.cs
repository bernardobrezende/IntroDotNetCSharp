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

        public PremiumBeer() { }

        public PremiumBeer(string name, double initialWeight, string country = default(string))
            : base(name, country, initialWeight)
        {
        }
    }
}