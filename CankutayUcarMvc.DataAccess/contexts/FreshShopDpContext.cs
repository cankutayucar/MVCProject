using CankutayUcarMvc.Model.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.DataAccess.contexts
{
    public class FreshShopDpContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FreshShopDp;Trusted_Connection=True;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
