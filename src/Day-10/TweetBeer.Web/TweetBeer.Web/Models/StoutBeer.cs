namespace TweetBeer.Web.Models
{
    public partial class StoutBeer
    {
        public override bool HasAlcohol
        {
            get { return true; }
            set { }
        }

        public StoutBeer() { }

        public StoutBeer(string name, double initialWeight, string country = default(string))
            : base(name, country ?? "IR", initialWeight)
        {
        }
    }
}