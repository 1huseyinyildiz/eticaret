using shopapp.entity;
using System.Collections.Generic;

namespace shopapp.business.Abstract
{
    public interface IProductService
    {
        Product GetById (int id);

        List<Product> GetAll ();

        void Create (Product entity);

        void Update (Product entity);

        void Delete (Product entity);

        Product GetProduct();
    }
}