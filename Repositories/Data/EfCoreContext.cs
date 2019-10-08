using Microsoft.EntityFrameworkCore;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Data
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(DbContextOptions<EfCoreContext> opt) : base(opt)
        {          
        }
        public DbSet<Buyer> Buyers { get; set; }
    }
}
