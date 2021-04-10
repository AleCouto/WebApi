using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public string Number { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey("StockLocal")]
        public int Id { get; set; }
        public StockLocal StockLocal { get; set; }

        public Order()
        {
          
        }

        public Order(int orderId, string number, int quantity, string description)
        {
            OrderId = orderId;
            Number = number;
            Quantity = quantity;
            Description = description;
        }

        public Order(Book book, StockLocal stockLocal)
        {
            Book = book;
            StockLocal = stockLocal;
        }
    }
}
