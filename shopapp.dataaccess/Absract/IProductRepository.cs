using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.dataaccess.Absract {
    public interface IProductRepository :IRepository<Product>{
        void getProductWithCategory();

        Product GetProduct();

    }
}