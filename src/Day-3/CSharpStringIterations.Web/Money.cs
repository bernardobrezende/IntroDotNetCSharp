using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpTypes.Web
{
    public struct Money
    {
        // Private is the default accessor
        private decimal value;

        private const decimal MaxValue = 1000M;
        private readonly decimal MinValue;

        /// <summary>
        /// Represents a money.
        /// </summary>
        /// <param name="value">Value for the money.</param>
        public Money(decimal value)
        {
            this.value = value;
            this.MinValue = 6;
        }

        public override string ToString()
        {        
            return "R$ " + this.value.ToString();
        }

        /// <summary>
        /// Factory Method.
        /// </summary>
        /// <returns></returns>
        public static Money Thousand()
        {
            return new Money(MaxValue);
        }

        public Money One()
        {
            return new Money(1);
        }
    }
}