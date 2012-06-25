
namespace CSharpInterfacesInheritance.Web.MyClasses
{
    public class StoutBeer : Beer
    {
        public StoutBeer(string beerName, double weight)
            : base(beerName, "IR", weight)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"></param>
        /// <exception cref="StoutDrinkException"></exception>
        public override void Drink(double weight)
        {
            bool canDrink = weight == (this.Weight / 2);
            if (!canDrink)            
                throw new StoutDrinkException();
            
            base.Drink(weight);
        }

        public override bool HasAlcohol
        {
            get
            {
                return true;
            }
            set { }
        }
    }
}