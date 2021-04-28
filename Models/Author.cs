using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Author name")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Author")]
        public string Name { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Language")]
        public string Language { get; set; }

        [StringLength(120, MinimumLength = 3)]
        public string Description { get; set; }

        public IList<AuthorBook> AuthorBook { get; set; }

        public Author()
        {

        }

        public Author(int authorId, string name)
        {
            AuthorId = authorId;
            Name = name;
        }
        public Author(int authorId, string name, string country, string language)
        {
            AuthorId = authorId;
            Name = name;
            Country = country;
            Language = language;    
        }

        public Author(IList<AuthorBook> authorBook)
        {
            AuthorBook = authorBook;
        }
    }
}
