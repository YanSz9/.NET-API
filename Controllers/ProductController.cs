using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        var product = _context.Procucts.ToList();
        if (product is null)
        {
            return NotFound("Produtos não encontrados");
        }
        return product;
    }
    [HttpGet("{id:int}", Name = "ObterProduto")]
    public ActionResult<Product> Get(int id)
    {
        var product = _context.Procucts.FirstOrDefault(p => p.ProductId == id);
        if (product is null)
        {
            return NotFound("Produto não encontrado");
        }
        return product;
    }
    [HttpPost]
    public ActionResult Post(Product product)
    {
        if (product is null)
            return BadRequest();

        _context.Procucts.Add(product);
        _context.SaveChanges();

        return new CreatedAtRouteResult("ObterProduto", new { id = product.ProductId }, product);
    }
}
