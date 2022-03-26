using ShoppingApplication.DAL;
using ShoppingApplication.Helper;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class AdminBAL
    {
        public List<Product> GetProducts()
        {
            return new AdminDAL().GetProducts();
        }
        public void AddRole(Role role)
        {
            new AdminDAL().AddRole(role);
        }
        public Role GetRole(int Id)
        {
            return new AdminDAL().GetRole(Id);
        }
        public void EditRole(Role role)
        {
            new AdminDAL().EditRole(role);
        }
        public void DeleteRole(int Id)
        {
            new AdminDAL().DeleteRole(Id);
        }
        public List<Role> GetRoles()
        {
            return new AdminDAL().GetRoles();
        }
        public void AddUser(User user)
        {
            user.JoinedOn = DateTime.UtcNow.AddHours(5);
            user.AccessToken = new RandomGenerator().GenerateAccessToken();
            new AdminDAL().AddUser(user);
        }
        public User GetUser(int Id)
        {
            return new AdminDAL().GetUser(Id);
        }
        public void EditUser(User user)
        {
            new AdminDAL().EditUser(user);
        }
        public void DeleteUser(int Id)
        {
            new AdminDAL().DeleteUser(Id);
        }
        public List<User> GetUsers()
        {
            return new AdminDAL().GetUsers();
        }
        public List<User> GetBuyers()
        {
            return new AdminDAL().GetBuyers();
        }
        public List<User> GetSellers()
        {
            return new AdminDAL().GetSellers();
        }
        public void AddCity(City city)
        {
            new AdminDAL().AddCity(city);
        }
        public City GetCity(int Id)
        {
            return new AdminDAL().GetCity(Id);
        }
        public void EditCity(City city)
        {
            new AdminDAL().EditCity(city);
        }
        public void DeleteCity(int Id)
        {
            new AdminDAL().DeleteCity(Id);
        }
        public List<City> GetCities()
        {
            return new AdminDAL().GetCities();
        }
        public void AddAddressDetail(AddressDetail addressDetail)
        {
            new AdminDAL().AddAddressDetail(addressDetail);
        }
        public AddressDetail GetAddressDetail(int Id)
        {
            return new AdminDAL().GetAddressDetail(Id);
        }
        public void EditAddressDetail(AddressDetail addressDetail)
        {
            new AdminDAL().EditAddressDetail(addressDetail);
        }
        public void DeleteAddressDetail(int Id)
        {
            new AdminDAL().DeleteAddressDetail(Id);
        }
        public List<AddressDetail> GetAddressDetails()
        {
            return new AdminDAL().GetAddressDetails();
        }
        public void AddCategory(Category category)
        {
            new AdminDAL().AddCategory(category);
        }
        public Category GetCategory(int Id)
        {
            return new AdminDAL().GetCategory(Id);
        }
        public void EditCategory(Category category)
        {
            new AdminDAL().EditCategory(category);
        }
        public void DeleteCategory(int Id)
        {
            new AdminDAL().DeleteCategory(Id);
        }
        public List<Category> GetCategories()
        {
            return new AdminDAL().GetCategories();
        }
        public void AddSubCategory(SubCategory subCategory)
        {
            new AdminDAL().AddSubCategory(subCategory);
        }
        public SubCategory GetSubCategory(int Id)
        {
            return new AdminDAL().GetSubCategory(Id);
        }
        public void EditSubCategory(SubCategory subCategory)
        {
            new AdminDAL().EditSubCategory(subCategory);
        }
        public void DeleteSubCategory(int Id)
        {
            new AdminDAL().DeleteSubCategory(Id);
        }
        public List<SubCategory> GetSubCategories()
        {
            return new AdminDAL().GetSubCategories();
        }
        public void AddProudctStatus(ProductStatus productStatus)
        {
            new AdminDAL().AddProudctStatus(productStatus);
        }
        public ProductStatus GetProductStatus(int Id)
        {
            return new AdminDAL().GetProductStatus(Id);
        }
        public void EditProductStatus(ProductStatus productStatus)
        {
            new AdminDAL().EditProductStatus(productStatus);
        }
        public void DeleteProductStatus(int Id)
        {
            new AdminDAL().DeleteProductStatus(Id);
        }
        public List<ProductStatus> GetProductStatuses()
        {
            return new AdminDAL().GetProductStatuses();
        }
        public void AddProduct(Product product)
        {
            product.AddedOn = DateTime.UtcNow.AddHours(5);
            new AdminDAL().AddProduct(product);
        }
        public Product GetProduct(int Id)
        {
            return new AdminDAL().GetProduct(Id);
        }
        public void EditProduct(Product product)
        {
            new AdminDAL().EditProduct(product);
        }
        public void DeleteProduct(int Id)
        {
            new AdminDAL().DeleteProduct(Id);
        }
        public void AddOrderStatus(OrderStatus orderStatus)
        {
            new AdminDAL().AddOrderStatus(orderStatus);
        }
        public OrderStatus GetOrderStatus(int Id)
        {
            return new AdminDAL().GetOrderStatus(Id);
        }
        public void EditOrderStatus(OrderStatus orderStatus)
        {
            new AdminDAL().EditOrderStatus(orderStatus);
        }
        public void DeleteOrderStatus(int Id)
        {
            new AdminDAL().DeleteOrderStatus(Id);
        }
        public List<OrderStatus> GetOrderStatuses()
        {
            return new AdminDAL().GetOrderStatuses();
        }
        public void AddOrder(Order order)
        {
            order.CreatedOn = DateTime.UtcNow.AddHours(5);
            new AdminDAL().AddOrder(order);
        }
        public Order GetOrder(int Id)
        {
            return new AdminDAL().GetOrder(Id);
        }
        public void EditOrder(Order order)
        {
            new AdminDAL().EditOrder(order);
        }
        public void DeleteOrder(int Id)
        {
            new AdminDAL().DeleteOrder(Id);
        }
        public List<Order> GetOrders()
        {
            return new AdminDAL().GetOrders();
        }
    }
}
