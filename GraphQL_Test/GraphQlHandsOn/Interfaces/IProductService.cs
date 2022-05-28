using GraphQlHandsOn.Models;

namespace GraphQlHandsOn.Interfaces; 

public interface IProductService {
  List<Product> GetAllProducts();
  Product GetProductById(int id);
  Product AddProduct(Product product);
  Product UpdateProduct(int id, Product product);
  void DeleteProduct(int id);
}