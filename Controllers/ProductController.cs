using Microsoft.AspNetCore.Mvc;
using WebApi.Context;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context){
        _context = context;
    }
}
