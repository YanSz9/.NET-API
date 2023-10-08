using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Procucts(Name, Description, Price, ImageUrl, Stock, DateRegister, CategoryId) " +
            "Values('Coca-Cola', 'Refrigerante de Cola 1000ML', '6.00', 'cocacola.jpg', 30, GetDate(),1)");
             mb.Sql("Insert into Procucts(Name, Description, Price, ImageUrl, Stock, DateRegister, CategoryId) " + 
             "Values('Papel Higiênico', 'Papel Higiênico Neve Folha Dupla', '17.50', 'papel.jpg', 30, GetDate(),2)" );
             mb.Sql("Insert into Procucts(Name, Description, Price, ImageUrl, Stock, DateRegister, CategoryId) " + 
             "Values('KitKat', 'Chocolate Kit-Kat', '4.00', 'kitkat.jpg', 30, GetDate(),3)" );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");
        }
    }
}
