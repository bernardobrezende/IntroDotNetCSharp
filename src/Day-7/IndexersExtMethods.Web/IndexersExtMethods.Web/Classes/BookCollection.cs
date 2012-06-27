using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexersExtMethods.Web.Classes
{
    public class BookCollection
    {
        public IList<Book> Books { get; private set; }

        public BookCollection()
        {
            this.Books = new List<Book>();
        }

        public void Add(Book b)
        {
            if (b == null)
                throw new ArgumentNullException("Book cannot be null.");
            //
            this.Books.Add(b);
        }

        #region Indexers

        public Book this[int index]
        {
            get
            {
                return this.Books[index];
            }
        }

        public Book this[string name]
        {
            get
            {
                return this.Books.FirstOrDefault(x => x.Name == name);                
            }
        }

        #endregion
    }
}