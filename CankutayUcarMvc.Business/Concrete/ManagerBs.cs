using CankutayUcarMvc.Business.Abstract;
using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.Business.Concrete
{
    public class ManagerBs : IManagerBs
    {
        private readonly IManagerRepository _bs;
        public ManagerBs(IManagerRepository bs)
        {
            _bs = bs;
        }

        public void Delete(Manager entity)
        {
            _bs.Delete(entity);
        }

        public Manager Get(Expression<Func<Manager, bool>> filter)
        {
            return _bs.Get(filter);
        }

        public List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null)
        {
            return _bs.GetAll(filter);
        }

        public Manager GetByEmail(string email)
        {
            return _bs.GetByEmail(email);
        }

        public Manager GeyByID(int id)
        {
            return _bs.GeyByID(id);
        }

        public int Insert(Manager entity)
        {
            return _bs.Insert(entity);
        }

        public Manager LogIn(string userName, string password)
        {
            return _bs.LogIn(userName, password);
        }

        public void Update(Manager entity)
        {
            _bs.Update(entity);
        }
    }
}
