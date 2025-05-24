using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantityInStockToProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantityInStock",
                schema: "Catalog",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityInStock",
                schema: "Catalog",
                table: "Products");
        }
    }
}
