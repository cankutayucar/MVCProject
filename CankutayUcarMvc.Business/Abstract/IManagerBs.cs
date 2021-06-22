using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Abstract
{
    public interface IManagerBs
    {
        Manager Get(Expression<Func<Manager, bool>> filter);
        List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null);
        Manager GeyByID(int id);
        int Insert(Manager entity);
        void Delete(Manager entity);
        void Update(Manager entity);
        Manager LogIn(string userName, string password);
        Manager GetByEmail(string email);
    }
}
