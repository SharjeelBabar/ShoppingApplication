using ShoppingApplication.DAL;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class ProductBAL
    {
        public List<Product> GetProducts()
        {
            return new ProductDAL().GetProducts();
        }
        public List<Product> GetMyProducts(int Id)
        {
            return new ProductDAL().GetMyProducts(Id);
        }
        public void AddImages(List<Image> images)
        {
            new ProductDAL().AddImages(images);
        }
        public List<SubCategory> GetSubCategories()
        {
            return new ProductDAL().GetSubCategories();
        }
        public List<ProductStatus> GetProductStatuses()
        {
            return new ProductDAL().GetProductStatuses();
        }

        public void AddProduct(Product product)
        {
            product.AddedOn = DateTime.UtcNow.AddHours(5);
            new ProductDAL().AddProduct(product);
        }
        public Product GetProduct(int Id)
        {
            return new ProductDAL().GetProduct(Id);
        }
        public void EditProduct(Product product)
        {
            new ProductDAL().EditProduct(product);
        }
        public void DeleteProduct(int Id)
        {
            new ProductDAL().DeleteProduct(Id);
        }
    }
}
