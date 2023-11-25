using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialExchangeAPI.Migrations
{
    /// <inheritdoc />
    public partial class OptionalSellerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Sellers_SellerId",
                table: "Materials");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Materials",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Sellers_SellerId",
                table: "Materials",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Sellers_SellerId",
                table: "Materials");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Materials",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Sellers_SellerId",
                table: "Materials",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
