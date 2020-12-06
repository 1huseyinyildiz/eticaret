using System.Collections.Generic;
using System.Runtime.CompilerServices;
using shopapp.dataaccess.Absract;
using shopapp.entity;

namespace shopapp.dataaccess.Concrete.EfCoreRepository
{
    public class EfCoreProductRepository : EfCoreGerenericRepository<Product, EfShopContext>,
    IProductRepository
    {

        public Product GetProduct()
        {
            Product product = new Product()
            {
                Name = "test",
                Description = "test",
            };
            return product;
        }

        public void getProductWithCategory()
        {
            var test="";
        }
    }
}