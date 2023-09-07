using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GanresGanreId",
                table: "Book",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Book_GanresGanreId",
                table: "Book",
                column: "GanresGanreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Ganres_GanresGanreId",
                table: "Book",
                column: "GanresGanreId",
                principalTable: "Ganres",
                principalColumn: "GanreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Ganres_GanresGanreId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_GanresGanreId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "GanresGanreId",
                table: "Book");
        }
    }
}
