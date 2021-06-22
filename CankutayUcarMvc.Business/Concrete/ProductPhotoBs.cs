using CankutayUcarMvc.Business.Abstract;
using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Concrete
{
    public class ProductPhotoBs : IProductPhotoBs
    {
        private readonly IProductPhotoRepository _bs;
        public ProductPhotoBs(IProductPhotoRepository bs)
        {
            _bs = bs;
        }

        public void Delete(ProductPhoto entity)
        {
            _bs.Delete(entity);
        }

        public ProductPhoto Get(Expression<Func<ProductPhoto, bool>> filter)
        {
            return _bs.Get(filter);
        }

        public List<ProductPhoto> GetAll(Expression<Func<ProductPhoto, bool>> filter = null)
        {
            return _bs.GetAll(filter);
        }

        public ProductPhoto GeyByID(int id)
        {
            return _bs.GeyByID(id);
        }

        public int Insert(ProductPhoto entity)
        {
            return _bs.Insert(entity);
        }

        public void Update(ProductPhoto entity)
        {
            _bs.Update(entity);
        }
    }
}
