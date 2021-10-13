using System;

namespace BookLibrary
{
    public class Book
    {
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Author of the book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Number of the pages in the book
        /// </summary>
        public int PageNumber { get; set; }
        /// <summary>
        /// An unique identifier of the book
        /// </summary>
        public string ISBN13 { get; set; }
        
        public Book()
        {

        }
    }
}
