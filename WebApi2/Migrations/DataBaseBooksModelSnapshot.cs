﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

namespace WebApi2.Migrations
{
    [DbContext(typeof(DataBaseBooks))]
    partial class DataBaseBooksModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Country = "Portugal",
                            Language = "português",
                            Name = "Jose Saramago"
                        },
                        new
                        {
                            AuthorId = 2,
                            Country = "Portugal",
                            Language = "português",
                            Name = "Fernando Pessoa"
                        },
                        new
                        {
                            AuthorId = 3,
                            Country = "Portugal",
                            Language = "português",
                            Name = "Eça de Queirós"
                        },
                        new
                        {
                            AuthorId = 4,
                            Country = "Portugal",
                            Language = "português",
                            Name = "Miguel Torga"
                        });
                });

            modelBuilder.Entity("Models.AuthorBook", b =>
                {
                    b.Property<int>("AuthorBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorBookId");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookID");

                    b.ToTable("AuthorBook");

                    b.HasData(
                        new
                        {
                            AuthorBookId = 1,
                            AuthorID = 1,
                            BookID = 1
                        },
                        new
                        {
                            AuthorBookId = 2,
                            AuthorID = 2,
                            BookID = 2
                        },
                        new
                        {
                            AuthorBookId = 3,
                            AuthorID = 3,
                            BookID = 3
                        },
                        new
                        {
                            AuthorBookId = 4,
                            AuthorID = 4,
                            BookID = 4
                        });
                });

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("PublishCompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookId");

                    b.HasIndex("PublishCompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Amount = 100,
                            Genre = "Romance",
                            Price = 17m,
                            PublishCompanyId = 1,
                            Title = "Ensaio sobre a Cegueira",
                            Year = 1995
                        },
                        new
                        {
                            BookId = 2,
                            Amount = 150,
                            Genre = "Poesia",
                            Price = 18m,
                            PublishCompanyId = 2,
                            Title = "Poemas Completos de Alberto Caeiro",
                            Year = 1946
                        },
                        new
                        {
                            BookId = 3,
                            Amount = 150,
                            Genre = "Romance",
                            Price = 8m,
                            PublishCompanyId = 3,
                            Title = "O Primo Basílio",
                            Year = 1878
                        },
                        new
                        {
                            BookId = 4,
                            Amount = 150,
                            Genre = "Poesia",
                            Price = 10m,
                            PublishCompanyId = 1,
                            Title = "Bichos",
                            Year = 1940
                        });
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.HasIndex("BookId");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            BookId = 2,
                            Id = 1,
                            Quantity = 0
                        },
                        new
                        {
                            OrderId = 2,
                            BookId = 1,
                            Id = 2,
                            Quantity = 0
                        },
                        new
                        {
                            OrderId = 3,
                            BookId = 4,
                            Id = 1,
                            Quantity = 0
                        },
                        new
                        {
                            OrderId = 4,
                            BookId = 3,
                            Id = 2,
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("Models.PublishCompany", b =>
                {
                    b.Property<int>("PublishCompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT");

                    b.HasKey("PublishCompanyId");

                    b.ToTable("PublishCompany");

                    b.HasData(
                        new
                        {
                            PublishCompanyId = 1,
                            Address = "Rua da Restauração 365",
                            Email = "porto@porto.com.pt",
                            Name = "Porto",
                            PhoneNumber = 226088322,
                            PostalCode = 4099023,
                            Website = "www.portoeditora.pt"
                        },
                        new
                        {
                            PublishCompanyId = 2,
                            Address = "Rua Professor Jorge Silva Horta 1",
                            Email = "bertrand@editoa.com.pt",
                            Name = "Bertrand Editora",
                            PhoneNumber = 217626000,
                            PostalCode = 1500499,
                            Website = "www.bertrandeditora.pt"
                        },
                        new
                        {
                            PublishCompanyId = 3,
                            Address = "Rua Cidade de Córdova 2",
                            Email = "leya@editora.com.pt",
                            Name = "Leya",
                            PhoneNumber = 214272200,
                            PostalCode = 42610038,
                            Website = "www.leya.com"
                        });
                });

            modelBuilder.Entity("Models.StockLocal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Local")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StockLocal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Local = "Lisboa"
                        },
                        new
                        {
                            Id = 2,
                            Local = "Porto"
                        });
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FiscalNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Indentification")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address = "Rua Vitimas da Guerra 30",
                            Email = "aecmar@hotmail.com",
                            Name = "Alexandre Couto",
                            PhoneNumber = 222222222,
                            PostalCode = 2825420
                        },
                        new
                        {
                            UserId = 2,
                            Address = "Rua Lisboa 40",
                            Email = "jg@hotmail.com",
                            Name = "João Golçalves",
                            PhoneNumber = 333333333,
                            PostalCode = 1234567
                        },
                        new
                        {
                            UserId = 3,
                            Address = "Rua Almirante reis 3",
                            Email = "apjose@hotmail.com",
                            Name = "Pedro Jose",
                            PhoneNumber = 444444444,
                            PostalCode = 7654321
                        });
                });

            modelBuilder.Entity("Models.AuthorBook", b =>
                {
                    b.HasOne("Models.Author", "Author")
                        .WithMany("AuthorBook")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Book", "Book")
                        .WithMany("AuthorBook")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.HasOne("Models.PublishCompany", "PublishCompany")
                        .WithMany("books")
                        .HasForeignKey("PublishCompanyId");

                    b.HasOne("Models.User", null)
                        .WithMany("Book")
                        .HasForeignKey("UserId");

                    b.Navigation("PublishCompany");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.HasOne("Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.StockLocal", "StockLocal")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.User", null)
                        .WithMany("Order")
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("StockLocal");
                });

            modelBuilder.Entity("Models.Author", b =>
                {
                    b.Navigation("AuthorBook");
                });

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.Navigation("AuthorBook");
                });

            modelBuilder.Entity("Models.PublishCompany", b =>
                {
                    b.Navigation("books");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Navigation("Book");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
