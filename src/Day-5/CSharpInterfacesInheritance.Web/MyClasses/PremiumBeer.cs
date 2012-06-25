
namespace CSharpInterfacesInheritance.Web.MyClasses
{
    public class PremiumBeer : Beer
    {
        public PremiumBeer(string beerName)
            : base(beerName)
        {
        }

        public override bool HasAlcohol
        {
            get
            {
                return this.Name != "Kronenbier";
            }
            set { }
        }

        public override string ToString()
        {
            return "Premium Beer";
        }
    }
}