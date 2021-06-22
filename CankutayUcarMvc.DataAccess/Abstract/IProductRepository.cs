using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.DataAccess.Abstract
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        List<Product> GetByCategorId(int categoryId);
        List<Product> GetByPriceRange(decimal minPrice, decimal maxPrice);
    }
}
