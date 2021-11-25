using Microsoft.EntityFrameworkCore;
using Model.Domain.Entities;
using Model.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
        }       
       


    }
}
