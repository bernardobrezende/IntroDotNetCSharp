using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpClasses.Web.MyClasses
{
    public class Beer
    {
        #region Fields

        private string name;
        private string country;

        #endregion

        #region Properties

        // Properties canonical form
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        // Properties shortcut style (new in C# 3)
        public string Country { get; private set; }
        public double Weight { get; set; }
        // Flag
        private Boolean IsOpened { get; set; }
        public double InitialWeight { get; private set; }
        public IList<string> Errors { get; set; }

        #endregion

        #region Constructors

        public Beer(string beerName, string country = default(string), double initialWeight = default(double))
        {
            if (String.IsNullOrEmpty(beerName))
                throw new ArgumentException("Beer name is required.");
            
            this.name = beerName;
            // Null coalsing and ternary operator samples
            this.country = country ?? "Brasil";
            this.country = country != null ? country : "Brasil";
            this.Errors = new List<string>();
            this.Weight = this.InitialWeight = initialWeight;
        }

        #endregion

        #region Methods

        public void Open()
        {
            this.IsOpened = true;
        }

        public void Drink(double weight)
        {
            if (!this.IsOpened)
                //throw new InvalidOperationException("Beer must be opened!");
                this.Errors.Add("Beer must be opened!");
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

        #endregion        
    }
}