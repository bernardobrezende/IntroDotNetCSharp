using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTypes.Web
{
    public partial class Exercise2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnUSD_Click(object sender, EventArgs e)
        {
            decimal usdValue = Decimal.Parse(this.TextBox1.Text);
            MoneyForExercise2 usd = new MoneyForExercise2(usdValue, Currency.USD);
            //
            this.lblFormattedMoney.Text = usd.ToString();
        }

        protected void btnBRL_Click(object sender, EventArgs e)
        {
            decimal brlValue = Decimal.Parse(this.TextBox1.Text);
            MoneyForExercise2 brl = new MoneyForExercise2(brlValue, Currency.BRL);
            //
            this.lblFormattedMoney.Text = brl.ToString();
        }
    }
}