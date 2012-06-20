using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTypes.Web
{
    public partial class Exercise1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal value1 = Decimal.Parse(this.TextBox1.Text);
            decimal value2 = Decimal.Parse(this.TextBox2.Text);
            //
            Money total = new Money(value1 + value2);
            //
            this.Label1.Text = total.ToString();
        }
    }
}