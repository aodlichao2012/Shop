using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Shop.Models
{
    public class DbEntity : DbContext
    {
        public DbEntity(DbContextOptions<DbEntity> options) : base(options)
        { }
        public DbSet<Customers> Customers { get; set; }
    }
}
