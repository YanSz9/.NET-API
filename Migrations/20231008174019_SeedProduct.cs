using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Bebidas', 'Bebida.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Higiene', 'Higiene.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Sobremesas', 'Sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");
        }
    }
}
