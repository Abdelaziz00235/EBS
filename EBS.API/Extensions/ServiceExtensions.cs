using EBS.Business.Abstract;
using EBS.Business.Concrete;
using EBS.DataAccess.Abstract;
using EBS.DataAccess.Concrete;
using EBS.DataAccess.Repositories;

namespace EBS.API.Extensions
{
    public  static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection services)
        {


            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IAgenceRepository, AgenceRepository>();
            services.AddScoped<IAgenceService, AgenceManager>();

            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IBannerService, BannerManager>();

            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IBasketService, BasketManager>();


            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IBrandService, BrandManager>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepartmentService, DepartmentManager>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeManager>();

            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IMessageService, MessageManager>();


            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderManager>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IProductReviewRepository, ProductReviewRepository>();
            services.AddScoped<IProductReviewService, ProductReviewManager>();


            services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
            services.AddScoped<IPurchaseOrderService, PurchaseOrderManager>();


            services.AddScoped<IRequestPurchaseOrExecutionWorkRepository, RequestPurchaseOrExecutionWorkRepository>();
            services.AddScoped<IRequestPurchaseOrExecutionWorkService, RequestPurchaseOrExecutionWorkManager>();


            services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
            services.AddScoped<ISubCategoryService, SubCategoryManager>();


            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ISupplierService, SupplierManager>();


            services.AddScoped<IWitshListRepository, WitshListRepository>();
            services.AddScoped<IWitshListService, WitshListManager>();

        }
    }
}
