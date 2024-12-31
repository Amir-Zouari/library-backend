using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblio.Data.Migrations
{
    public partial class _5thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "BookBorrow");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Borrows");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvailableCopies",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BorrowId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Borrows_BorrowId",
                        column: x => x.BorrowId,
                        principalTable: "Borrows",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BookId",
                table: "Tags",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookId",
                table: "Authors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_BookId",
                table: "CartItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_BorrowId",
                table: "CartItem",
                column: "BorrowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Books_BookId",
                table: "Tags",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Books_BookId",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BookId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "AvailableCopies",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Authors");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Borrows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookBorrow",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    BorrowsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBorrow", x => new { x.BooksId, x.BorrowsId });
                    table.ForeignKey(
                        name: "FK_BookBorrow_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBorrow_Borrows_BorrowsId",
                        column: x => x.BorrowsId,
                        principalTable: "Borrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrow_BorrowsId",
                table: "BookBorrow",
                column: "BorrowsId");
        }
    }
}
