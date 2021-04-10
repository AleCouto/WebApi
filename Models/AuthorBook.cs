using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AuthorBook
    {
        [Key]
        public int AuthorBookId { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}

