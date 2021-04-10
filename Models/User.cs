using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy-}", ApplyFormatInEditMode = true)]
        public DateTime? Birthday { get; set; }

        [RegularExpression("[0-9]")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string Indentification { get; set; }
        public string FiscalNumber { get; set; }

        public virtual IList<Order> Order { get; set; }
        public virtual IList<Book> Book { get; set; }

        public User()
        {

        } 

        public User(int userId, string name, string email)
        {
            UserId = userId;
            Name = name;
            Email = email;
        }

        public User(int userId, string name, DateTime birthday, int phoneNumber, string email, string address, int postalCode, string indentification, string fiscalNumber)
        {
            UserId = userId;
            Name = name;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            PostalCode = postalCode;
            Indentification = indentification;
            FiscalNumber = fiscalNumber;
        }

        public User(IList<Order> order, IList<Book> book)
        {
            Order = order;
            Book = book;
        }
    }
}
