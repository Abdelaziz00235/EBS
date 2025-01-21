using EBS.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Context
{
    public class ApplicationDbContext : IdentityDbContext<Employee, EmployeeRole, int>
    { 
        public ApplicationDbContext(DbContextOptions ooptions):base(ooptions)  
        {
            
        }

        public ApplicationDbContext(DbSet<Agence> agences, DbSet<Department> departments, DbSet<Category> categories, DbSet<Brand> brands, DbSet<Order> orders, DbSet<PurchaseOrder> purchaseOrders, DbSet<RequestPurchaseOrExecutionWork> requestPurchaseOrExecutionWorks, DbSet<Supplier> suppliers, DbSet<About> abouts, DbSet<Banner> banners, DbSet<Contact> contacts, DbSet<Message> messages, DbSet<Employee> employees, DbSet<Basket> baskets, DbSet<Product> products, DbSet<ProductReview> productReviews, DbSet<SubCategory> subCategories, DbSet<WitshList> witshLists)
        {
            Agences = agences;
            Departments = departments;
            Categories = categories;
            Brands = brands;
            Orders = orders;
            PurchaseOrders = purchaseOrders;
            RequestPurchaseOrExecutionWorks = requestPurchaseOrExecutionWorks;
            Suppliers = suppliers;
            Abouts = abouts;
            Banners = banners;
            Contacts = contacts;
            Messages = messages;
            Employees = employees;
            Baskets = baskets;
            Products = products;
            ProductReviews = productReviews;
            SubCategories = subCategories;
            WitshLists = witshLists;
        }

        public DbSet<Agence> Agences { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<RequestPurchaseOrExecutionWork> RequestPurchaseOrExecutionWorks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Employee> Employees  { get; set; }
        public DbSet<Basket> Baskets  { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<ProductReview> ProductReviews  { get; set; }
        public DbSet<SubCategory>  SubCategories { get; set; }
        public DbSet<WitshList> WitshLists { get; set; }

        



    }
}
