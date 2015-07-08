using System.Collections.Generic;
using System.Linq;

namespace BaseClassProblem.BusinessLayer
{
    public interface IShoppingCartService
    {
        int GetCartItemCount();
        IEnumerable<string> GetCartItems();
    }

    public class ShoppingCartService : IShoppingCartService
    {
        public int GetCartItemCount()
        {
            return 42;
        }

        public IEnumerable<string> GetCartItems()
        {
            return Enumerable.Empty<string>();
        }
    }
}
