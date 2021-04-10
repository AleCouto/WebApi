using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Laguage = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "PublishCompany",
                columns: table => new
                {
                    PublishCompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Website = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishCompany", x => x.PublishCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "StockLocal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Local = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLocal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Birthday = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Indentification = table.Column<string>(type: "TEXT", nullable: true),
                    FiscalNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 120, nullable: true),
                    PublishCompanyId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_PublishCompany_PublishCompanyId",
                        column: x => x.PublishCompanyId,
                        principalTable: "PublishCompany",
                        principalColumn: "PublishCompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorBookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorID = table.Column<int>(type: "INTEGER", nullable: false),
                    BookID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => x.AuthorBookId);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Book_BookID",
                        column: x => x.BookID,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_StockLocal_Id",
                        column: x => x.Id,
                        principalTable: "StockLocal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Country", "Description", "Laguage", "Name" },
                values: new object[] { 1, "Portugal", null, "português", "Jose Saramago" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Country", "Description", "Laguage", "Name" },
                values: new object[] { 2, "Portugal", null, "português", "Fernando Pessoa" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Country", "Description", "Laguage", "Name" },
                values: new object[] { 3, "Portugal", null, "português", "Eça de Queirós" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Country", "Description", "Laguage", "Name" },
                values: new object[] { 4, "Portugal", null, "português", "Miguel Torga" });

            migrationBuilder.InsertData(
                table: "PublishCompany",
                columns: new[] { "PublishCompanyId", "Address", "Email", "Name", "PhoneNumber", "PostalCode", "Website" },
                values: new object[] { 1, "Rua da Restauração 365", "porto@porto.com.pt", "Porto", 226088322, 4099023, "www.portoeditora.pt" });

            migrationBuilder.InsertData(
                table: "PublishCompany",
                columns: new[] { "PublishCompanyId", "Address", "Email", "Name", "PhoneNumber", "PostalCode", "Website" },
                values: new object[] { 2, "Rua Professor Jorge Silva Horta 1", "bertrand@editoa.com.pt", "Bertrand Editora", 217626000, 1500499, "www.bertrandeditora.pt" });

            migrationBuilder.InsertData(
                table: "PublishCompany",
                columns: new[] { "PublishCompanyId", "Address", "Email", "Name", "PhoneNumber", "PostalCode", "Website" },
                values: new object[] { 3, "Rua Cidade de Córdova 2", "leya@editora.com.pt", "Leya", 214272200, 42610038, "www.leya.com" });

            migrationBuilder.InsertData(
                table: "StockLocal",
                columns: new[] { "Id", "Local" },
                values: new object[] { 1, "Lisboa" });

            migrationBuilder.InsertData(
                table: "StockLocal",
                columns: new[] { "Id", "Local" },
                values: new object[] { 2, "Porto" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "Birthday", "Email", "FiscalNumber", "Indentification", "Name", "PhoneNumber", "PostalCode" },
                values: new object[] { 1, "Rua Vitimas da Guerra 30", null, "aecmar@hotmail.com", null, null, "Alexandre Couto", 222222222, 2825420 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "Birthday", "Email", "FiscalNumber", "Indentification", "Name", "PhoneNumber", "PostalCode" },
                values: new object[] { 2, "Rua Lisboa 40", null, "jg@hotmail.com", null, null, "João Golçalves", 333333333, 1234567 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "Birthday", "Email", "FiscalNumber", "Indentification", "Name", "PhoneNumber", "PostalCode" },
                values: new object[] { 3, "Rua Almirante reis 3", null, "apjose@hotmail.com", null, null, "Pedro Jose", 444444444, 7654321 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Amount", "Description", "Genre", "Price", "PublishCompanyId", "Title", "UserId", "Year" },
                values: new object[] { 1, 100, null, "Romance", 17m, 1, "Ensaio sobre a Cegueira", null, 1995 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Amount", "Description", "Genre", "Price", "PublishCompanyId", "Title", "UserId", "Year" },
                values: new object[] { 4, 150, null, "Poesia", 10m, 1, "Bichos", null, 1940 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Amount", "Description", "Genre", "Price", "PublishCompanyId", "Title", "UserId", "Year" },
                values: new object[] { 2, 150, null, "Poesia", 18m, 2, "Poemas Completos de Alberto Caeiro", null, 1946 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Amount", "Description", "Genre", "Price", "PublishCompanyId", "Title", "UserId", "Year" },
                values: new object[] { 3, 150, null, "Romance", 8m, 3, "O Primo Basílio", null, 1878 });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorBookId", "AuthorID", "BookID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorBookId", "AuthorID", "BookID" },
                values: new object[] { 4, 4, 4 });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorBookId", "AuthorID", "BookID" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorBookId", "AuthorID", "BookID" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "BookId", "Description", "Id", "Number", "Quantity", "UserId" },
                values: new object[] { 2, 1, null, 2, null, 0, null });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "BookId", "Description", "Id", "Number", "Quantity", "UserId" },
                values: new object[] { 3, 4, null, 1, null, 0, null });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "BookId", "Description", "Id", "Number", "Quantity", "UserId" },
                values: new object[] { 1, 2, null, 1, null, 0, null });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "BookId", "Description", "Id", "Number", "Quantity", "UserId" },
                values: new object[] { 4, 3, null, 2, null, 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_AuthorID",
                table: "AuthorBook",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BookID",
                table: "AuthorBook",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublishCompanyId",
                table: "Book",
                column: "PublishCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_UserId",
                table: "Book",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Id",
                table: "Order",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "StockLocal");

            migrationBuilder.DropTable(
                name: "PublishCompany");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
