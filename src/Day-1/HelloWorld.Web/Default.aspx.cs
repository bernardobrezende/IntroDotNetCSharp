using System;
using System.Web.UI;

namespace HelloWorld.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.myH2.InnerText = "Hello World by C# code!";
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            this.myH2.InnerText = "Button Clicked!";
            //
            this.showInputText.InnerText = this.TextBox1.Text;
        }
    }
}