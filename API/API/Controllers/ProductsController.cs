using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IGenericRepository<Product> _productRepository;
    private readonly IGenericRepository<ProductBrand> _productBrand;
    private readonly IGenericRepository<ProductType> _productType;
    private readonly IMapper _mapper;

    public ProductsController(IGenericRepository<Product> productRepository, 
        IGenericRepository<ProductBrand> productBrand, IGenericRepository<ProductType> productType,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _productBrand = productBrand;
        _productType = productType;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<ProductDTO>>> GetProducts()
    {
        var spec = new ProductsWithTypeAndBrand();
        var products = await _productRepository.ListAsync(spec);
        return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDTO>>(products));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDTO>> GetProduct(int id)
    {
        var spec = new ProductsWithTypeAndBrand(id);

        var product = await _productRepository.GetEntityWithSpec(spec);
        return Ok(_mapper.Map<Product, ProductDTO>(product));
    }

    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands() 
    {
        return Ok(await  _productBrand.GetAllAsync());
    }

    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
    {
        return Ok(await _productType.GetAllAsync());
    }
}

