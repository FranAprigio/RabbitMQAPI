using RabbitMQProductAPI.Data;
using RabbitMQProductAPI.Models;

namespace RabbitMQProductAPI.Service;

    public class ProductService: IProductService
    {
        private readonly DbContextProduct _dbContext;
        public ProductService(DbContextProduct dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Product> GetProductList()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProductById(int Id)
        {
            return _dbContext.Products.Where(x => x.ProductId == Id).FirstOrDefault();
        }

        public Product AddProduct(Product product)
        {
            var result = _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Product UpdateProduct(Product product)
        {
            var result = _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteProduct(int Id)
        {
            var filterData = _dbContext.Products.Where(x => x.ProductId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filterData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
    