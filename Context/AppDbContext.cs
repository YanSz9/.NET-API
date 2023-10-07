using Microsoft.EntityFrameworkCore;
using WebApi.models;

namespace WebApi.Context;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options): base( options ){


    }
    public DbSet<Categorie>? Categories {get;set;}
    public DbSet<Product>? Procucts {get;set;}

}