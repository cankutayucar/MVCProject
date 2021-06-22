using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.DataAccess.Contexts;
using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.DataAccess.Concrete
{
    public class ManagerRepository : RepositoryBase<Manager, FreshShopDpContext>, IManagerRepository
    {
        public Manager GetByEmail(string email)
        {
            return this.Get(x => x.Email == email);
        }

        public Manager LogIn(string userName, string password)
        {
            return this.Get(x => x.UserName == userName && x.Password == password);
        }
    }
}
