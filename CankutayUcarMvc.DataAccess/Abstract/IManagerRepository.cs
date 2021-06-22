using CankutayUcarMvc.Model.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.DataAccess.Abstract
{
    public interface IManagerRepository : IRepositoryBase<Manager>
    {
        Manager LogIn(string userName, string password);
        Manager GetByEmail(string email);
    }
}
