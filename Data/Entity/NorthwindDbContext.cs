using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün_CRUD.Data.Entity
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=Northwind;trusted_connection=true";
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
