using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class StockLocal
    {
        [Key]
        public int Id { get; set; }
        public string Local { get; set; }

        public StockLocal()
        {
        
        }

        public StockLocal(int id, string local)
        {
            Id = id;
            this.Local = local;
        }

    }
}
