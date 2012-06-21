using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;

namespace CSharpTypes.Web
{
    public partial class ArrayPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region Creating int array

            // Canonical form
            int[] arr = new int[3];
            arr[0] = 5;
            arr[1] = 2;
            // Creating using type-initializer
            int[] arr2 = new int[3] { 5, 2, 4 };
            // Using anonymous type
            string[] arr3 = new[] { "s", "o", "s" };
            // Using type-inference
            var arr4 = new[] { "str1", "str2", "str3" };

            #endregion

            #region Array operations

            Array.Sort(arr2);
            int str2Index = Array.IndexOf(arr4, "str2");
            Array.Reverse(arr2);
            // Using linq
            string res = (from x in arr3
                          where x == "o"
                          select x).First();

            #region Using Lambda Expressions

            DateTime[] dates = new DateTime[2];
            dates[0] = DateTime.Now;
            dates[1] = DateTime.Now.AddYears(1);

            DateTime currentYearDate =
                dates.Where(x => x.Year == 2012).First();

            #endregion

            #endregion

            #region Arrays Iterating

            string[] beers = new string[] { "Polar", "Hoeggarden", "Estrela" };

            //for (int i = 0; i < beers.Length; i++)
            //{
            //    string b = beers[i];
            //    this.ListBox1.Items.Add(b);
            //}

            //foreach (string beer in beers)
            //{
            //    this.ListBox1.Items.Add(beer);
            //}

            // While
            //int i = 0;
            //while (i < beers.Length)
            //{
            //    this.ListBox1.Items.Add(beers[i]);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    this.ListBox1.Items.Add(beers[i]);
            //    i++;
            //} while (i < beers.Length);

            //Parallel.ForEach(beers, x => 
            //{
            //    this.ListBox1.Items.Add(x);
            //});

            //foreach (var beer in beers)
            //{
            //    if (beer == "Hoeggarden")
            //        break;
            //    this.ListBox1.Items.Add(beer);
            //}

            foreach (var beer in beers)
            {
                if (beer == "Hoeggarden") continue;
                this.ListBox1.Items.Add(beer);
            }

            #endregion
        }
    }
}