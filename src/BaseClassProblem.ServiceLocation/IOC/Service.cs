using BaseClassProblem.BusinessLayer;
using Caliburn.Micro;

namespace BaseClassProblem.ServiceLocation.IOC
{
    public static class Service
    {
        private static readonly SimpleContainer Container;

        static Service()
        {
            Container = new SimpleContainer();
            Container.PerRequest<IAuthenticationService, AuthenticationService>();
            Container.PerRequest<ICatalogueService, CatalogueService>();
            Container.PerRequest<ICustomerService, CustomerService>();
            Container.PerRequest<ILoggingService, LoggingService>();
            Container.PerRequest<IMetricsService, MetricsService>();
            Container.PerRequest<IOrderService, OrderService>();
            Container.PerRequest<IShoppingCartService, ShoppingCartService>();

        }
        public static T Locate<T>() where T : class
        {
            return Container.GetInstance(typeof(T), null) as T;
        }
    }
}