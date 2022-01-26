using Commerce_API.Data.Interface;
using Commerce_API.Data.Repository;
using Commerce_API.Data.Specification;
using Commerce_API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGenericRepository<Product> repo;

        public ProductController(IGenericRepository<Product> repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts() 
        {
            var spec = new ProductSpecification();
            return Ok(await repo.GetAllItemsAsync(spec));
        }
    }
}
