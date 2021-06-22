using CankutayUcarMvc.Business.Abstract;
using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Concrete
{
    public class ProductBs : IProductBs
    {
        private readonly IProductRepository _bs;
        public ProductBs(IProductRepository bs)
        {
            _bs = bs;
        }
        public void Delete(Product entity)
        {
            _bs.Delete(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _bs.Get(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _bs.GetAll(filter);
        }

        public List<Product> GetByCategorId(int categoryId)
        {
            return _bs.GetByCategorId(categoryId);
        }

        public List<Product> GetByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _bs.GetByPriceRange(minPrice, maxPrice);
        }

        public Product GeyByID(int id)
        {
            return _bs.GeyByID(id);
        }

        public int Insert(Product entity)
        {
            return _bs.Insert(entity);
        }

        public void Update(Product entity)
        {
            _bs.Update(entity);
        }
    }
}
