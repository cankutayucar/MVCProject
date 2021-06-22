using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.Model.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CankutayUcarMvc.DataAccess.Concrete
{
    public class RepositoryBase<Tentity, TContext> : IRepositoryBase<Tentity>
        where Tentity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        public void Delete(Tentity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (TContext ctx = new TContext())
            {
                return ctx.Set<Tentity>().FirstOrDefault(filter);
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (TContext ctx = new TContext())
            {
                if (filter == null) return ctx.Set<Tentity>().ToList();
                else return ctx.Set<Tentity>().Where(filter).ToList();
            }
        }

        public Tentity GeyByID(int id)
        {
            using (TContext ctx = new TContext())
            {
                return ctx.Set<Tentity>().SingleOrDefault(x => x.ID == id);
            }
        }

        public int Insert(Tentity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Added;
                return ctx.SaveChanges();
            }
        }

        public void Update(Tentity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
