using Mooc.DataAccess.Entities;
using Mooc.DataAccess.Entities.EntityConfig;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc.DataAccess.Context
{

    public class DataContext : DbContext, IDataContextProvider
    {
        public DataContext() : base(GetConnectionString())
        {
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.UserModelBuilder();
        }

        public DataContext GetDataContext()
        {
            return this;
        }
    }
}
