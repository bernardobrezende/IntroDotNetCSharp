using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Globalization;

namespace CSharpLinqToXml.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnReadXML_Click(object sender, EventArgs e)
        {
            // TODO: Read XML file.
            string path = Server.MapPath("App_Data/books.xml");
            XDocument booksXml = XDocument.Load(path);

            #region Fetching first book

            var firstBook = booksXml.Descendants("book").First();
            string firstBookId = firstBook.Attribute("id").Value;
            string firstBookAuthor = firstBook.Element("author").Value;
            string firstBookTitle = firstBook.Element("title").Value;
            string firstBookGenre = firstBook.Element("genre").Value;
            decimal firstBookPrice = Decimal.Parse(firstBook.Element("price").Value,
                new CultureInfo("en-US"));

            DateTime firstBookPublishDate =
                DateTime.Parse(firstBook.Element("publish_date").Value);

            string firstBookDescription = firstBook.Element("description").Value;

            #endregion

            // Exercício: Pegar apenas os livros que custarem > 30
            #region foreach version

            List<string> names = new List<string>();
            foreach (XElement node in booksXml.Descendants("book"))
            {
                if (Decimal.Parse(node.Element("price").Value, new CultureInfo("en-US")) > 30)
                {
                    names.Add(node.Element("title").Value);
                }
            }

            #endregion

            #region Linq To XML version

            var booksMoreThan30 = from b in booksXml.Descendants("book").AsParallel()
                                  where Decimal.Parse(b.Element("price").Value,
                                    new CultureInfo("en-US")) > 30
                                  select new Book(b.Element("title").Value);

            decimal mostExpensivePrice = booksXml
                .Descendants("book")
                .Max(book => Decimal.Parse(book.Element("price").Value, new CultureInfo("en-US")));

            Decimal cheapestPrice = booksXml
                .Descendants("book")
                .Min(book => Decimal.Parse(book.Element("price").Value, new CultureInfo("en-US")));            

            #endregion

            #region Fetching books into a Dropdownlist

            var tempList = from b in booksXml.Descendants("book").AsParallel()
                                  where Decimal.Parse(b.Element("price").Value,
                                    new CultureInfo("en-US")) > 30
                           orderby b.Element("publish_date").Value descending
                           select new ListItem(
                               text: b.Element("title").Value, 
                               value: b.Attribute("id").Value);

            this.ddlBooks.Items.AddRange(tempList.ToArray());
            this.ddlBooks.Items.Insert(0, "Selecione");

            //this.ddlBooks.Items.AddRange
            //(
            //    (from b in booksXml.Descendants("book")
            //    //where Decimal.Parse(b.Element("price").Value, new CultureInfo("en-US")) > 30
            //     orderby b.Element("publish_date").Value descending
            //    select new ListItem(b.Element("title").Value, b.Attribute("id").Value)
            //    ).ToArray()
            //);

            #endregion
        }

        protected void ddlBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem selectedItem = this.ddlBooks.SelectedItem;
        }        
    }

    public class Book
    {
        public string Name { get; set; }

        public Book(string bookName)
        {
            this.Name = bookName;
        }
    }
}