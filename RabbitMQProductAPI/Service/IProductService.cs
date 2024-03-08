using RabbitMQProductAPI.Models;

namespace RabbitMQProductAPI.Service;

public interface IProductService
{
    public IEnumerable<Product> GetProductList();
    public Product GetProductById(int Id);
    public Product AddProduct(Product product);
    public Product UpdateProduct(Product product);
    public bool DeleteProduct(int Id);
}