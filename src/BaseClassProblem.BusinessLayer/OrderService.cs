using System.Collections.Generic;
using System.Linq;

namespace BaseClassProblem.BusinessLayer
{
    public interface IOrderService
    {
        IEnumerable<string> GetOrders();
    }

    public class OrderService : IOrderService
    {
        public IEnumerable<string> GetOrders()
        {
            return Enumerable.Empty<string>();
        }
    }
}
