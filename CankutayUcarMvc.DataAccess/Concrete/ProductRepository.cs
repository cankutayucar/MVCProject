using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.DataAccess.Contexts;
using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.DataAccess.Concrete
{
    public class ProductRepository : RepositoryBase<Product, FreshShopDpContext>, IProductRepository
    {
        public List<Product> GetByCategorId(int categoryId)
        {
            return this.GetAll(x => x.CategoryID == categoryId);
        }

        public List<Product> GetByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return this.GetAll(x => x.Price >= minPrice && x.Price <= maxPrice);
        }
    }
}
