using GraphQlHandsOn.Interfaces;
using GraphQlHandsOn.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlHandsOn.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController {
  private readonly IProductService _productService;

  public ProductController(IProductService productService) {
    _productService = productService;
  }

  [HttpGet]
  public IActionResult GetProducts() {
    return new OkObjectResult(_productService.GetAllProducts());
  }

  [HttpGet("{id}")]
  public IActionResult GetProduct(int id) {
    return new OkObjectResult(_productService.GetProductById(id));
  }

  [HttpPost]
  public IActionResult PostProduct(Product product) {
    return new OkObjectResult(_productService.AddProduct(product));
  }

  [HttpPut("{id}")]
  public IActionResult PutProduct(int id, Product product) {
    return new OkObjectResult(_productService.UpdateProduct(id, product));
  }

  [HttpDelete]
  public IActionResult DeleteProduct(int id) {
    _productService.DeleteProduct(id);

    return new OkResult();
  }
}