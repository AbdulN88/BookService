using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Book
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        [Required]
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
        /// Gets or sets the author id
        /// </summary>
        //Foreign Key
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the author model object
        /// </summary>
        //Navigation Property
        public Author Author { get; set; }
    }
}