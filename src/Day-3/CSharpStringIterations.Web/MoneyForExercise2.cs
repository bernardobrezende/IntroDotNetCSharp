using System.Globalization;
using System;
namespace CSharpTypes.Web
{
    public struct MoneyForExercise2
    {
        // Private is the default accessor
        private decimal value;
        private Currency currency;

        private const decimal MaxValue = 1000M;
        private readonly decimal MinValue;

        /// <summary>
        /// Represents a money.
        /// </summary>
        /// <param name="value">Value for the money.</param>
        public MoneyForExercise2(decimal value, Currency currency)
        {
            this.value = value;
            this.MinValue = 6;
            //
            this.currency = currency;
        }

        public override string ToString()
        {
            #region Using if statement solution

            //if (this.currency == Currency.USD)
            //    return "U$ " + this.value.ToString();
            //else if (this.currency == Currency.GBP)
            //{
            //    return "£ " + this.value.ToString();
            //}
            //else
            //    return "R$ " + this.value.ToString();

            #endregion

            #region Using switch statement solution

            CultureInfo moneyCulture = default(CultureInfo);

            switch (this.currency)
            {
                case Currency.USD:
                    moneyCulture = new CultureInfo("en-US");
                    break;
                case Currency.GBP:
                    moneyCulture = new CultureInfo("en-GB");
                    break;
                case Currency.BRL:
                default:
                    moneyCulture = new CultureInfo("pt-BR");
                    break;
            }

            return String.Format(moneyCulture, "{0:c}", this.value);

            #endregion
        }

        /// <summary>
        /// Factory Method.
        /// </summary>
        /// <returns></returns>
        public static MoneyForExercise2 Thousand()
        {
            return new MoneyForExercise2(MaxValue, Currency.BRL);
        }

        public MoneyForExercise2 One()
        {
            return new MoneyForExercise2(1, Currency.BRL);
        }
    }
}