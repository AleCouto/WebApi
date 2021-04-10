using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PublishCompany
    {
        [Key]
        public int PublishCompanyId { get; set; }

        [Required(ErrorMessage = "Company name")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Company name")]
        public string Name { get; set; }

        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        public string Address { get; set; }

        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }
        public string Website { get; set; }

        public IList<Book> books { get; set; }

        public PublishCompany()
        {

        }

        public PublishCompany(int publishcompanyId, string name, int phoneNumber, string email)
        {
            PublishCompanyId = publishcompanyId;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public PublishCompany(int publishcompanyId, string name, int phoneNumber, string email, string address, int postalCode, string website)
        {
            PublishCompanyId = publishcompanyId;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            PostalCode = postalCode;
            Website = website;
        }

        public PublishCompany(IList<Book> books)
        {
            this.books = books;
        }
    }
}
