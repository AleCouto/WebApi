using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models;
namespace Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Title")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year")]
        [Display(Name = "Release Date")]
        public int Year { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required(ErrorMessage = "Genre")]
        [StringLength(30)]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Price")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1, 1000)]
        public int Amount { get; set; }

        [StringLength(120, MinimumLength = 3)]
        public string Description { get; set; }

        public IList<AuthorBook> AuthorBook { get; set; }

        [ForeignKey("PublishCompany")]
        public int? PublishCompanyId { get; set; }
        public PublishCompany PublishCompany { get; set; }

        public Book()
        {

        }

        public Book(int bookId, string title, decimal price, int amount)
        {
            BookId = bookId;
            Title = title;
            Price = price;
            Amount = amount;
        }

        public Book(int bookId, string title, int year, string genre, decimal price, int amount, string description)
        {
            BookId = bookId;
            Title = title;
            Year = year;
            Genre = genre;
            Price = price;
            Amount = amount;
            Description = description;
        }

        public Book(IList<AuthorBook> authorBook)
        {
            AuthorBook = authorBook;
        }
    }
}
