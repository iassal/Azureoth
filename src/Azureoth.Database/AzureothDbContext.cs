using Azureoth.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azureoth.Database
{
    public class AzureothDbContext : DbContext
    {
        public AzureothDbContext(DbContextOptions<AzureothDbContext> options) : base(options) { }

        #region Database Sets
        public DbSet<User> Users { get; set; }
        #endregion Database Sets
    }
}
