using System;

namespace TweetBeer.Web.Models
{
    public class BeerNotOpenedException : Exception
    {
        public BeerNotOpenedException(string message)
            : base(message)
        {
        }
    }
}