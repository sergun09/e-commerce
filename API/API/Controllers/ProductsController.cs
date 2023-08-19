using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{


    [HttpGet]
    public List<string> GetProducts()
    {
        return new List<string> { "Product 1", "Product 2" };
    }

    [HttpGet("{id}")]
    public string GetProduct(int id)
    {
        return "This is a product !";
    }
}

