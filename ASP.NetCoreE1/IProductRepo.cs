using System.Collections.Generic;

namespace ASP.NetCoreE1
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();

    }
}
