using System;

namespace CSharpEntityFramework.Web.Models
{
    public class BeerNotOpenedException : Exception
    {
        public BeerNotOpenedException(string message)
            : base(message)
        {
        }
    }
}