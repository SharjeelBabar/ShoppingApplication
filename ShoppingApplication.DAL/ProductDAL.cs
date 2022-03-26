using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class ProductDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
        public List<Product> GetMyProducts(int Id)
        {
            return db.Products.Where(x => x.SellerId == Id).ToList();
        }
        public void AddImages(List<Image> images)
        {
            foreach (var item in images)
            {
                db.Images.Add(item);
            }
            db.SaveChanges();
        }
        public List<SubCategory> GetSubCategories()
        {
            return db.SubCategories.ToList();
        }
        public List<ProductStatus> GetProductStatuses()
        {
            return db.ProductStatuses.ToList();
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public Product GetProduct(int Id)
        {
            return db.Products.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditProduct(Product product)
        {
            var DbProduct = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            if (DbProduct != null)
            {
                if (!String.IsNullOrEmpty(product.Title))
                {
                    DbProduct.Title = product.Title;
                }
                if (!String.IsNullOrEmpty(product.Price))
                {
                    DbProduct.Price = product.Price;
                }
                if (!String.IsNullOrEmpty(product.SellerId.ToString()))
                {
                    DbProduct.SellerId = product.SellerId;
                }
                if (!String.IsNullOrEmpty(product.SubCategoryId.ToString()))
                {
                    DbProduct.SubCategoryId = product.SubCategoryId;
                }
                if (!String.IsNullOrEmpty(product.ProductStatusId.ToString()))
                {
                    DbProduct.ProductStatusId = product.ProductStatusId;
                }
            }
            db.SaveChanges();
        }
        public void DeleteProduct(int Id)
        {
            db.Products.Remove(db.Products.Find(Id));
            db.SaveChanges();
        }
    }
}
