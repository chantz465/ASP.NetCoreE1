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

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
                new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
                new { name = product.Name, price = product.Price, id = product.ProductID  });
        }


    }
}
