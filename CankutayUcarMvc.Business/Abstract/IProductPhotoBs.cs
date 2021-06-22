using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Abstract
{
    public interface IProductPhotoBs
    {
        ProductPhoto Get(Expression<Func<ProductPhoto, bool>> filter);
        List<ProductPhoto> GetAll(Expression<Func<ProductPhoto, bool>> filter = null);
        ProductPhoto GeyByID(int id);
        int Insert(ProductPhoto entity);
        void Delete(ProductPhoto entity);
        void Update(ProductPhoto entity);
    }
}
