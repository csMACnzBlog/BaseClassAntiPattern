using System.Collections.Generic;
using System.Linq;

namespace BaseClassProblem.BusinessLayer
{
    public interface ICatalogueService
    {
        IEnumerable<string> GetCatalogues();
        IEnumerable<string> GetTopItems();
    }

    public class CatalogueService : ICatalogueService
    {
        public IEnumerable<string> GetCatalogues()
        {
            return Enumerable.Empty<string>();
        }

        public IEnumerable<string> GetTopItems()
        {
            return Enumerable.Empty<string>();
        }
    }
}
