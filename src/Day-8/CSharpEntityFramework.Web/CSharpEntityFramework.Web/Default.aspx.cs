using System;
using CSharpEntityFramework.Web.Models;

namespace CSharpEntityFramework.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Beer b = new PremiumBeer();
        }
    }
}