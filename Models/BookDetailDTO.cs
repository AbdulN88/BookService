using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.Models
{
    public class BookDetailDTO
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the genre
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets the author name
        /// </summary>
        //Foreign Key
        public string AuthorName { get; set; }
    }
}