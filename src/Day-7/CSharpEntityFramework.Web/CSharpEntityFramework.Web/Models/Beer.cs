using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpEntityFramework.Web.Models
{
    public partial class Beer
    {
        #region Properties

        public IList<string> Errors { get; set; }
        //public abstract bool HasAlcohol { get; set; }

        #endregion

        #region Constructors

        public Beer()
        {
            this.Errors = new List<string>();
        }

        public Beer(string beerName, string country = default(string), double initialWeight = default(double))
            : this()
        {
            if (String.IsNullOrEmpty(beerName))
                throw new ArgumentException("Beer name is required.");

            this.Name = beerName;
            // Null coalsing and ternary operator samples
            this.Country = country ?? "Brasil";
            this.Country = country != null ? country : "Brasil";            
            this.Weight = this.InitialWeight = initialWeight;
        }

        #endregion

        #region Methods

        public void Open()
        {
            this.IsOpened = true;
        }

        /// <summary>
        /// Drink the corresponding weight.
        /// </summary>
        /// <param name="weight">Weight to drink</param>
        /// <exception cref="BeerNotOpenedException">Throws Exception if beer is not opened.</exception>
        public virtual void Drink(double weight)
        {
            if (!this.IsOpened)
                throw new BeerNotOpenedException("Beer must be opened!");
            //this.Errors.Add("Beer must be opened!");
            else if (weight > this.InitialWeight)
                this.Errors.Add("Cannot drink too much!");
            // 
            this.Weight -= weight;
        }

        public IEnumerable<string> DrinkAndGetErrors(double weight)
        {
            if (!this.IsOpened)
                yield return "Beer must be opened!";
            if (weight > this.InitialWeight)
                yield return "Cannot drink too much!";
            //
            this.Weight -= weight;
        }

        public override string ToString()
        {
            return "Beer";
        }

        #endregion
    }
}