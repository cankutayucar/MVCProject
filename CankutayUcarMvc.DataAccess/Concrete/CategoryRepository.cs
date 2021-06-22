using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.DataAccess.Contexts;
using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.DataAccess.Concrete
{
    public class CategoryRepository : RepositoryBase<Category, FreshShopDpContext>, ICategoryRepository
    {
    }
}
