using System;
using System.Configuration;
using TweetBeer.Web.Models;
using TweetSharp;

namespace TweetBeer.Web.Twitter
{
    public static class BeerExtensions
    {
        public static void Tweet(this Beer beer, string message)
        {
            if (message.Length > 140)
                throw new ArgumentOutOfRangeException("Tweet must have at maximum 140 characters.");

            TwitterService tw = new TwitterService(
                ConfigurationManager.AppSettings["TwitterConsumerKey"],
                ConfigurationManager.AppSettings["TwitterConsumerSecret"]);

            var requestToken = tw.GetRequestToken();

            //tw.AuthenticateWith(requestToken.Token, requestToken.TokenSecret);

            tw.AuthenticateWith(
                ConfigurationManager.AppSettings["TwitterToken"],
                ConfigurationManager.AppSettings["TwitterTokenSecret"]);

            TwitterStatus ts = tw.SendTweet(message);
        }
    }
}