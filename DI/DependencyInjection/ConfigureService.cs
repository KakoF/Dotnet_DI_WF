using Data.Implementations;
using Domain.Interfaces.Implementations;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace DI.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICustomerService, CustomerService>();
            serviceCollection.AddTransient<IOrderItemService, OrderItemService>();
            serviceCollection.AddTransient<IOrderService, OrderService>();
            serviceCollection.AddTransient<IProductService, ProductService>();
            serviceCollection.AddTransient<ISupplierService, SupplierService>();

            serviceCollection.AddTransient<ICustomerImplementation, CustomerImplementation>();
            serviceCollection.AddTransient<IOrderImplementation, OrderImplementation>();
            serviceCollection.AddTransient<IOrderItemImplementation, OrderItemImplementation>();
            serviceCollection.AddTransient<IProductImplementation, ProductImplementation>();
            serviceCollection.AddTransient<ISupplierImplementation, SupplierImplementation>();


        }
    }
}