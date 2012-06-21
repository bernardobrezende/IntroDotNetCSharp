using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTypes.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Boxing

            Int32 myInteger = 456; // Value Type
            Object myObj = myInteger; // Putting value "into the box"

            #endregion

            #region Unboxing

            int valueFromUnboxing = (int)myObj; // Unboxing;
            // Nullable (two forms below represent the same)
            int? valueFromUnboxingAs = myObj as int?;
            Nullable<int> myNullable = new Nullable<int>();

            #endregion

            #region as operator

            string name = "john doe";
            object myNameObj = name;

            try
            {
                int age = (int)myNameObj;
            } catch { }

            int? age2 = myNameObj as int?;

            #endregion

            Money oneBRL = new Money(780.50M);

            string brl = oneBRL.ToString();
        }

        protected void btnEval_Click(object sender, EventArgs e)
        {
            var hundredBRL = new Money(100M);
            this.lblTotal.Text = hundredBRL.ToString();

            // Anonymous type
            var x = new
            {
                Nome = "bernardo",
                Idade = "24",
            };

            #region Calling static member
            
            var thousand = Money.Thousand();

            #endregion

            #region Calling non-static members (instance members)

            var moneyObj = new Money();
            moneyObj.One();

            #endregion

            #region Calling methods By Ref

            decimal b = 100;
            this.DoSomething(ref b);

            this.lblTotal.Text = b.ToString();

            #endregion

            #region Calling methods By Ref with Reference Objects

            string goodBeer = "abadessa";
            this.ToUpper(ref goodBeer);
            this.lblTotal.Text = goodBeer;

            #endregion

            #region Calling methods with out parameters

            int v100 = 100, res;
            this.Multiply(value: v100, result: out res);

            // Using TryParse method
            bool success;
            int valueParsed;
            success = Int32.TryParse("foo", out valueParsed);

            if (!success)
                Response.Redirect("http://www.lmgtfy.com/?q=foo is not " + valueParsed);

            #endregion
        }

        private void DoSomething(ref decimal v)
        {
            v *= 2; // v = v * 2;            
        }

        private void ToUpper(ref string str)
        {
            str = str.ToUpper();
        }

        private void Multiply(int value, out int result)
        {
            result = value * 2;
        }
    }
}