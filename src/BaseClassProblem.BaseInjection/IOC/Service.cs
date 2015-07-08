using System;
using System.Collections.Generic;
using System.Linq;
using BaseClassProblem.BaseInjection.Controllers;
using BaseClassProblem.BusinessLayer;
using Caliburn.Micro;
using WebGrease.Css.Extensions;

namespace BaseClassProblem.BaseInjection.IOC
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

            //Register Controllers
            var baseType = typeof(ControllerBase);
            baseType.Assembly
                .GetTypes()
                .Where(t => baseType.IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface)
                .ForEach(controllerType =>
                    Container.RegisterPerRequest(controllerType, null, controllerType));
        }
        public static T Locate<T>() where T : class
        {
            return Container.GetInstance(typeof(T), null) as T;
        }

        public static object Locate(Type serviceType)
        {
            return Container.GetInstance(serviceType, null);
        }
        public static IEnumerable<object> LocateAll(Type serviceType)
        {
            return Container.GetAllInstances(serviceType);
        }
    }
}