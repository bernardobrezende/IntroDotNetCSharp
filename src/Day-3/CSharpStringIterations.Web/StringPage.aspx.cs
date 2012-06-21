using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace CSharpTypes.Web
{
    public partial class StringPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region String Methods

            if (String.IsNullOrEmpty(this.TextBox1.Text))
            {
                // TODO: Shows label error
                return;
            }
            //this.TextBox1.Text = this.TextBox1.Text.ToUpper();
            //this.TextBox1.Text = this.TextBox1.Text.ToLower();
            //this.TextBox1.Text = this.TextBox1.Text.Substring(0, 3);
            //this.TextBox1.Text = this.TextBox1.Text.Substring(0, 3);

            //if (this.TextBox1.Text.Contains("google"))
            //    Response.Redirect("http://www.google.com");

            //if (this.TextBox1.Text.Equals("terra", StringComparison.InvariantCultureIgnoreCase))
            //    Response.Redirect("http://www.terra.com.br");

            //this.TextBox1.Text = this.TextBox1.Text.Replace("google", "gugou");

            //this.TextBox1.Text += " Suffix";
            //this.TextBox1.Text = String.Concat(this.TextBox1.Text, "Suffix2");
            //this.TextBox1.Text = "Preffix " + this.TextBox1.Text + " Suffix";            

            #endregion

            #region StringBuilder Methods

            StringBuilder stringBuilder = new StringBuilder("bernardo", 1024);
            stringBuilder.Append(" bosak");
            stringBuilder.Append(" de rezende");
            stringBuilder.AppendFormat("{0:0.00}", 6546.54987465);
            stringBuilder.AppendLine("c sharp");

            stringBuilder.Replace(" bosak", String.Empty);

            this.TextBox1.Text = stringBuilder.ToString();

            #endregion
        }
    }
}