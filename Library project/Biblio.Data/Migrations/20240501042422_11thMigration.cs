using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblio.Data.Migrations
{
    /// <inheritdoc />
    public partial class _11thMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Books_BookId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Borrows_BorrowId",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem");

            migrationBuilder.RenameTable(
                name: "CartItem",
                newName: "CartItems");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_BorrowId",
                table: "CartItems",
                newName: "IX_CartItems_BorrowId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_BookId",
                table: "CartItems",
                newName: "IX_CartItems_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Books_BookId",
                table: "CartItems",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Borrows_BorrowId",
                table: "CartItems",
                column: "BorrowId",
                principalTable: "Borrows",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Books_BookId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Borrows_BorrowId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItem");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_BorrowId",
                table: "CartItem",
                newName: "IX_CartItem_BorrowId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_BookId",
                table: "CartItem",
                newName: "IX_CartItem_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Books_BookId",
                table: "CartItem",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Borrows_BorrowId",
                table: "CartItem",
                column: "BorrowId",
                principalTable: "Borrows",
                principalColumn: "Id");
        }
    }
}
