using shopapp.business.Abstract;
using shopapp.dataaccess.Absract;
using shopapp.dataaccess.Concrete.EfCoreRepository;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {


        private IProductRepository productRepository;

        public ProductManager(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public void Create(Product entity)
        {
            ///iş kuralları

            productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {

            productRepository.Delete(entity);

        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return productRepository.GetById(id);
        }

        public Product GetProduct()
        {
            return productRepository.GetProduct();
        
        }

        public void Update(Product entity)
        {
            productRepository.Update(entity);
        }
    }
}
