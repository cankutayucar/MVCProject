using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Abstract
{
    public interface ICategoryBs
    {
        Category Get(Expression<Func<Category, bool>> filter);
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
        Category GeyByID(int id);
        int Insert(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
    }
}
