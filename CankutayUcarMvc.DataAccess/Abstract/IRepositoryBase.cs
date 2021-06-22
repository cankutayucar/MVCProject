using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.DataAccess.Abstract
{
    public interface IRepositoryBase<Tentity>
        where Tentity : BaseEntity, new()
    {
        Tentity Get(Expression<Func<Tentity, bool>> filter);
        List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null);
        Tentity GeyByID(int id);
        int Insert(Tentity entity);
        void Delete(Tentity entity);
        void Update(Tentity entity);
    }
}
