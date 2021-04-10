using Microsoft.EntityFrameworkCore;
using Models;

namespace WebApi.Data
{
    public class DataBaseBooks : DbContext

    {
        public DataBaseBooks (DbContextOptions<DataBaseBooks> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<PublishCompany> PublishCompany { get; set; }

        public DbSet<StockLocal> StockLocal { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Order> Order { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author() { AuthorId = 1, Name = "Jose Saramago", Country = "Portugal", Laguage = "português" },
                new Author() { AuthorId = 2, Name = "Fernando Pessoa", Country = "Portugal", Laguage = "português" },
                new Author() { AuthorId = 3, Name = "Eça de Queirós", Country = "Portugal", Laguage = "português" },
                new Author() { AuthorId = 4, Name = "Miguel Torga", Country = "Portugal", Laguage = "português" }
             );
            modelBuilder.Entity<PublishCompany>().HasData(
                new PublishCompany() { PublishCompanyId = 1, Name = "Porto", PhoneNumber = 226088322, Email = "porto@porto.com.pt", Address = "Rua da Restauração 365", PostalCode = 4099023, Website = "www.portoeditora.pt" },
                new PublishCompany() { PublishCompanyId = 2, Name = "Bertrand Editora", PhoneNumber = 217626000, Email = "bertrand@editoa.com.pt", Address = "Rua Professor Jorge Silva Horta 1", PostalCode = 1500499, Website = "www.bertrandeditora.pt" },
                new PublishCompany() { PublishCompanyId = 3, Name = "Leya", PhoneNumber = 214272200, Email = "leya@editora.com.pt", Address = "Rua Cidade de Córdova 2", PostalCode = 42610038, Website = "www.leya.com" }
             );
            modelBuilder.Entity<Book>().HasData(
                new Book() { BookId = 1, Title = "Ensaio sobre a Cegueira", Year = 1995, Genre = "Romance", Price = 17, Amount = 100, PublishCompanyId = 1 },
                new Book() { BookId = 2, Title = "Poemas Completos de Alberto Caeiro", Year = 1946, Genre = "Poesia", Price = 18, Amount = 150, PublishCompanyId = 2 },
                new Book() { BookId = 3, Title = "O Primo Basílio", Year = 1878, Genre = "Romance", Price = 8, Amount = 150, PublishCompanyId = 3 },
                new Book() { BookId = 4, Title = "Bichos", Year = 1940, Genre = "Poesia", Price = 10, Amount = 150, PublishCompanyId = 1 }
             );
            modelBuilder.Entity<AuthorBook>().HasData(
                new AuthorBook() { AuthorBookId = 1, AuthorID = 1, BookID = 1 },
                new AuthorBook() { AuthorBookId = 2, AuthorID = 2, BookID = 2 },
                new AuthorBook() { AuthorBookId = 3, AuthorID = 3, BookID = 3 },
                new AuthorBook() { AuthorBookId = 4, AuthorID = 4, BookID = 4 }
             );
            modelBuilder.Entity<User>().HasData(
                new User() { UserId = 1, Name = "Alexandre Couto", PhoneNumber = 222222222, Email = "aecmar@hotmail.com", Address = "Rua Vitimas da Guerra 30", PostalCode = 2825420, Birthday = null, Indentification = null, FiscalNumber = null },
                new User() { UserId = 2, Name = "João Golçalves", PhoneNumber = 333333333, Email = "jg@hotmail.com", Address = "Rua Lisboa 40", PostalCode = 1234567, Birthday = null, Indentification = null, FiscalNumber = null },
                new User() { UserId = 3, Name = "Pedro Jose", PhoneNumber = 444444444, Email = "apjose@hotmail.com", Address = "Rua Almirante reis 3", PostalCode = 7654321, Birthday = null, Indentification = null, FiscalNumber = null }
             );
            modelBuilder.Entity<StockLocal>().HasData(
                new StockLocal() { Id = 1, Local = "Lisboa" },
                new StockLocal() { Id = 2, Local = "Porto" }
             );
            modelBuilder.Entity<Order>().HasData(
                new Order() { OrderId = 1, Id = 1, BookId = 2 },
                new Order() { OrderId = 2, Id = 2, BookId = 1 },
                new Order() { OrderId = 3, Id = 1, BookId = 4 },
                new Order() { OrderId = 4, Id = 2, BookId = 3 }
             );
        }




    }
}
