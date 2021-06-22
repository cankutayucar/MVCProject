using CankutayUcarMvc.Business.Abstract;
using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Concrete
{
    public class CategoryBs : ICategoryBs
    {
        private readonly ICategoryRepository _bs;
        public CategoryBs(ICategoryRepository bs)
        {
            _bs = bs;
        }

        public void Delete(Category entity)
        {
            _bs.Delete(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _bs.Get(filter);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _bs.GetAll(filter);
        }

        public Category GeyByID(int id)
        {
            return _bs.GeyByID(id);
        }

        public int Insert(Category entity)
        {
            return _bs.Insert(entity);
        }

        public void Update(Category entity)
        {
            _bs.Update(entity);
        }
    }
}
