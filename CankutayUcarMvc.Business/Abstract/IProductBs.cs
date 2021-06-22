using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Abstract
{
    public interface IProductBs
    {
        Product Get(Expression<Func<Product, bool>> filter);
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
        Product GeyByID(int id);
        int Insert(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
        List<Product> GetByCategorId(int categoryId);
        List<Product> GetByPriceRange(decimal minPrice, decimal maxPrice);
    }
}
