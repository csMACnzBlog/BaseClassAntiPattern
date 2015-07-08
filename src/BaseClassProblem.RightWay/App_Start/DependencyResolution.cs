using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BaseClassProblem.RightWay.IOC;

namespace BaseClassProblem.RightWay
{
    public class DependencyResolution
    {
        public static void RegisterIOC()
        {
            DependencyResolver.SetResolver(new ServiceLocateResolver());
        }
    }

    public class ServiceLocateResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            return Service.Locate(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Service.LocateAll(serviceType);
        }
    }
}