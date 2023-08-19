using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    public StoreContext context;

    public ProductsController(StoreContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public async Task<List<Product>> GetProducts()
    {
        return await context.Products.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<Product> GetProduct(int id)
    {
        return await context.Products.FirstOrDefaultAsync(x => x.Id == id);
    }
}

