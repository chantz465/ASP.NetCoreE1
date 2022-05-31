using System.Collections.Generic;
using System.Data;
using System;
using Dapper;

namespace ASP.NetCoreE1
{
    public class ProductRepo : IProductRepo
    {
        private IDbConnection _conn;

        public ProductRepo(IDbConnection conn)
        {
            _conn = conn;
        }





        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
