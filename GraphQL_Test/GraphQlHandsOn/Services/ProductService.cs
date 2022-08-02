using GraphQlHandsOn.Interfaces;
using GraphQlHandsOn.Models;

namespace GraphQlHandsOn.Services;

public class ProductService : IProductService {
  private static readonly List<Product> _products = new() {
    new Product { Id = 1, Name = "Coffee", Price = 10 },
    new Product { Id = 2, Name = "Tea", Price = 15}
  };

  public List<Product> GetAllProducts() {
    return _products;
  }

  public Product GetProductById(int id) {
    return _products.Find(p => p.Id == id);
  }

  public Product AddProduct(Product product) {
    product.Id = _products.Max(p => p.Id) + 1;

    _products.Add(product);
    return product;
  }

  public Product UpdateProduct(int id, Product product) {
    var oldProduct = _products.Find(p => p.Id == id);
    if (oldProduct == null) {
      throw new Exception("Product wasn't found");
    }
    
    var oldProductIndex = _products.IndexOf(oldProduct);
    product.Id = oldProduct.Id;

    _products[oldProductIndex] = product;
    return product;
  }

  public void DeleteProduct(int id) {
    var oldProduct = _products.Find(p => p.Id == id);
    if (oldProduct == null) {
      throw new Exception("Product wasn't found");
    }
    
    var oldProductIndex = _products.IndexOf(oldProduct);
    _products.RemoveAt(oldProductIndex);
  }
}