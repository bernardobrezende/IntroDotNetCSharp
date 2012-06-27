using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using IndexersExtMethods.Web.Classes;
using IndexersExtMethods.Web.ExtMethods;

namespace IndexersExtMethods.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnReadXML_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("App_Data/books.xml");
            XDocument booksXml = XDocument.Load(path);

            #region Fetching first book

            var firstBook = booksXml.Descendants("book").First();
            string firstBookId = firstBook.Attribute("id").Value;
            string firstBookAuthor = firstBook.Element("author").Value;
            string firstBookTitle = firstBook.Element("title").Value;
            string firstBookGenre = firstBook.Element("genre").Value;
            decimal firstBookPrice = firstBook.Element("price").Value.ParseToDecimal();                

            DateTime firstBookPublishDate =
                DateTime.Parse(firstBook.Element("publish_date").Value);

            string firstBookDescription = firstBook.Element("description").Value;

            string str = "myBOOK";
            bool contains = str.ContainsIgnoreCase("book");

            #endregion

            #region foreach version

            List<string> names = new List<string>();
            foreach (XElement node in booksXml.Descendants("book"))
            {
                if (node.Element("price").Value.ParseToDecimal() > 30)
                {
                    names.Add(node.Element("title").Value);
                }
            }

            #endregion

            #region Linq To XML version

            var booksMoreThan30 = from b in booksXml.Descendants("book").AsParallel()
                                  where b.Element("price").Value.ParseToDecimal() > 30
                                  select new Book(b.Element("title").Value);

            decimal mostExpensivePrice = booksXml
                .Descendants("book")
                .Max(book => book.Element("price").Value.ParseToDecimal());

            Decimal cheapestPrice = booksXml
                .Descendants("book")
                .Min(book => book.Element("price").Value.ParseToDecimal());

            #endregion

            #region Indexers Sample

            //List<string> d = null;
            //d[78] = "oi"; //set
            //string v = d[5]; //get
            BookCollection myBookCollection = new BookCollection();
            myBookCollection.Add(new Book("Game of Thrones"));
            string name = myBookCollection[0].Name;

            Book hp = myBookCollection["Game of Thrones"];           

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