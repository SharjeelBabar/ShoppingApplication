using System;
using System.Collections.Generic;
using ShoppingApplication.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class AdminDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
        public void AddRole(Role role)
        {
            db.Roles.Add(role);
            db.SaveChanges();
        }
        public Role GetRole(int Id)
        {
            return db.Roles.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditRole(Role role)
        {
            var DbRole = db.Roles.Where(x => x.Id == role.Id).FirstOrDefault();
            if (DbRole != null)
            {
                if (!String.IsNullOrEmpty(role.Name))
                {
                    DbRole.Name = role.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteRole(int Id)
        {
            db.Roles.Remove(db.Roles.Find(Id));
            db.SaveChanges();
        }
        public List<Role> GetRoles()
        {
            return db.Roles.ToList();
        }
        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public User GetUser(int Id)
        {
            return db.Users.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditUser(User user)
        {
            var DbUser = db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (DbUser != null)
            {
                if (!String.IsNullOrEmpty(user.Name))
                {
                    DbUser.Name = user.Name;
                }
                if (!String.IsNullOrEmpty(user.Email))
                {
                    DbUser.Email = user.Email;
                }
                if (!String.IsNullOrEmpty(user.PhoneNumber))
                {
                    DbUser.PhoneNumber = user.PhoneNumber;
                }
                if (!String.IsNullOrEmpty(user.RoleId.ToString()))
                {
                    DbUser.RoleId = user.RoleId;
                }
                if (!String.IsNullOrEmpty(user.Password))
                {
                    DbUser.Password = user.Password;
                }
            }
            db.SaveChanges();
        }
        public void DeleteUser(int Id)
        {
            db.Users.Remove(db.Users.Find(Id));
            db.SaveChanges();
        }
        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }
        public List<User> GetBuyers()
        {
            return db.Users.Where(x => x.RoleId == 3).ToList();
        }
        public List<User> GetSellers()
        {
            return db.Users.Where(x => x.RoleId == 2).ToList();
        }
        public void AddCity(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
        }
        public City GetCity(int Id)
        {
            return db.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditCity(City city)
        {
            var DbCity = db.Cities.Where(x => x.Id == city.Id).FirstOrDefault();
            if (DbCity != null)
            {
                if (!String.IsNullOrEmpty(city.Name))
                {
                    DbCity.Name = city.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteCity(int Id)
        {
            db.Cities.Remove(db.Cities.Find(Id));
            db.SaveChanges();
        }
        public List<City> GetCities()
        {
            return db.Cities.ToList();
        }
        public void AddAddressDetail(AddressDetail addressDetail)
        {
            db.AddressDetails.Add(addressDetail);
            db.SaveChanges();
        }
        public AddressDetail GetAddressDetail(int Id)
        {
            return db.AddressDetails.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditAddressDetail(AddressDetail addressDetail)
        {
            var DbAddressDetail = db.AddressDetails.Where(x => x.Id == addressDetail.Id).FirstOrDefault();
            if (DbAddressDetail != null)
            {
                if (!String.IsNullOrEmpty(addressDetail.HouseNo))
                {
                    DbAddressDetail.HouseNo = addressDetail.HouseNo;
                }
                if (!String.IsNullOrEmpty(addressDetail.StreetNo))
                {
                    DbAddressDetail.StreetNo = addressDetail.StreetNo;
                }
                if (!String.IsNullOrEmpty(addressDetail.UserId.ToString()))
                {
                    DbAddressDetail.UserId = addressDetail.UserId;
                }
                if (!String.IsNullOrEmpty(addressDetail.CityId.ToString()))
                {
                    DbAddressDetail.CityId = addressDetail.CityId;
                }
                if (!String.IsNullOrEmpty(addressDetail.Area))
                {
                    DbAddressDetail.Area = addressDetail.Area;
                }
            }
            db.SaveChanges();
        }
        public void DeleteAddressDetail(int Id)
        {
            db.AddressDetails.Remove(db.AddressDetails.Find(Id));
            db.SaveChanges();
        }
        public List<AddressDetail> GetAddressDetails()
        {
            return db.AddressDetails.ToList();
        }
        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }
        public Category GetCategory(int Id)
        {
            return db.Categories.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditCategory(Category category)
        {
            var DbCategory = db.Categories.Where(x => x.Id == category.Id).FirstOrDefault();
            if (DbCategory != null)
            {
                if (!String.IsNullOrEmpty(category.Name))
                {
                    DbCategory.Name = category.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteCategory(int Id)
        {
            db.Categories.Remove(db.Categories.Find(Id));
            db.SaveChanges();
        }
        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public void AddSubCategory(SubCategory subCategory)
        {
            db.SubCategories.Add(subCategory);
            db.SaveChanges();
        }
        public SubCategory GetSubCategory(int Id)
        {
            return db.SubCategories.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditSubCategory(SubCategory subCategory)
        {
            var DbSubCategory = db.SubCategories.Where(x => x.Id == subCategory.Id).FirstOrDefault();
            if (DbSubCategory != null)
            {
                if (!String.IsNullOrEmpty(subCategory.Name))
                {
                    DbSubCategory.Name = subCategory.Name;
                }
                if (!String.IsNullOrEmpty(subCategory.CategoryId.ToString()))
                {
                    DbSubCategory.CategoryId = subCategory.CategoryId;
                }
            }
            db.SaveChanges();
        }
        public void DeleteSubCategory(int Id)
        {
            db.SubCategories.Remove(db.SubCategories.Find(Id));
            db.SaveChanges();
        }
        public List<SubCategory> GetSubCategories()
        {
            return db.SubCategories.ToList();
        }
        public void AddProudctStatus(ProductStatus productStatus)
        {
            db.ProductStatuses.Add(productStatus);
            db.SaveChanges();
        }
        public ProductStatus GetProductStatus(int Id)
        {
            return db.ProductStatuses.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditProductStatus(ProductStatus productStatus)
        {
            var DbProductStatus = db.ProductStatuses.Where(x => x.Id == productStatus.Id).FirstOrDefault();
            if (DbProductStatus != null)
            {
                if (!String.IsNullOrEmpty(productStatus.Name))
                {
                    DbProductStatus.Name = productStatus.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteProductStatus(int Id)
        {
            db.ProductStatuses.Remove(db.ProductStatuses.Find(Id));
            db.SaveChanges();
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
        public void AddOrderStatus(OrderStatus orderStatus)
        {
            db.OrderStatuses.Add(orderStatus);
            db.SaveChanges();
        }
        public OrderStatus GetOrderStatus(int Id)
        {
            return db.OrderStatuses.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditOrderStatus(OrderStatus orderStatus)
        {
            var DbOrderStatus = db.OrderStatuses.Where(x => x.Id == orderStatus.Id).FirstOrDefault();
            if (DbOrderStatus != null)
            {
                if (!String.IsNullOrEmpty(orderStatus.Name))
                {
                    DbOrderStatus.Name = orderStatus.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteOrderStatus(int Id)
        {
            db.OrderStatuses.Remove(db.OrderStatuses.Find(Id));
            db.SaveChanges();
        }
        public List<OrderStatus> GetOrderStatuses()
        {
            return db.OrderStatuses.ToList();
        }
        public void AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }
        public Order GetOrder(int Id)
        {
            return db.Orders.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditOrder(Order order)
        {
            var DbOrder = db.Orders.Where(x => x.Id == order.Id).FirstOrDefault();
            if (DbOrder != null)
            {
               
                if (!String.IsNullOrEmpty(order.BuyerId.ToString()))
                {
                    DbOrder.BuyerId = order.BuyerId;
                }
                if (!String.IsNullOrEmpty(order.ProductId.ToString()))
                {
                    DbOrder.ProductId = order.ProductId;
                }
                if (!String.IsNullOrEmpty(order.OrderStatusId.ToString()))
                {
                    DbOrder.OrderStatusId = order.OrderStatusId;
                }
            }
            db.SaveChanges();
        }
        public void DeleteOrder(int Id)
        {
            db.Orders.Remove(db.Orders.Find(Id));
            db.SaveChanges();
        }
        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }
    }
}
