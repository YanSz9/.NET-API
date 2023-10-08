using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace WebApi.models;

public class Categorie
{
    public Categorie()
    {
        Products = new Collection<Product>();
    }
    public int Id { get; set; }
    [Required]
    [MaxLength(80)]
    public string? Name { get; set; }
    [Required]
    [MaxLength(300)]
    public string? ImageUrl { get; set; }

    public ICollection<Product>? Products { get; set; }

}