
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.models;

namespace WebApi.Controllers;
[Route("[controller]")]
[ApiController]

public class CategorieController : ControllerBase
{
    private readonly AppDbContext _context;

    public CategorieController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("produtos")]
    public ActionResult<IEnumerable<Categorie>> GetCategoriasProdutos()
    {
        return _context.Categories.Include(p => p.Products).ToList();
    }

    [HttpGet]
    public ActionResult<IEnumerable<Categorie>> Get()
    {
        return _context.Categories.ToList();
    }

    [HttpGet("{id:int}", Name = "ObterCategorias")]
    public ActionResult<Categorie> Get(int id)
    {
        var categorie = _context.Categories.FirstOrDefault(p => p.Id == id);

        if (categorie == null)
        {
            return NotFound("Categoria não encontrada");
        }
        return categorie;
    }
    [HttpPost]
    public ActionResult Post(Categorie categorie)
    {
        if (categorie is null)
            return BadRequest();

        _context.Categories.Add(categorie);
        _context.SaveChanges();

        return new CreatedAtRouteResult("ObterCategoria", new { id = categorie.Id }, categorie);
    }
    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Categorie categorie)
    {
        if (id != categorie.Id)
        {
            return BadRequest();
        }
        _context.Entry(categorie).State = EntityState.Modified;
        _context.SaveChanges();
        return Ok(categorie);
    }
    [HttpDelete("{id:int}")]
    public ActionResult<Categorie> Delete(int id)
    {
        var categorie = _context.Categories.FirstOrDefault(p => p.Id == id);
        if (categorie == null)
        {
            return NotFound();
        }
        _context.Categories.Remove(categorie);
        _context.SaveChanges();
        return Ok(categorie);
    }

}