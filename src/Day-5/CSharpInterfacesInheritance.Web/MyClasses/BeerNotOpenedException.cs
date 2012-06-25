using System;

namespace CSharpInterfacesInheritance.Web.MyClasses
{
    public class BeerNotOpenedException : Exception
    {
        public BeerNotOpenedException(string message)
            : base(message)
        {
        }
    }
}