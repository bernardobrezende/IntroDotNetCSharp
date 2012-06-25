using System;

namespace CSharpInterfacesInheritance.Web.MyClasses
{
    public class StoutDrinkException : Exception
    {
        public StoutDrinkException() : base("Stout accepts only half-pint!") { }
    }
}