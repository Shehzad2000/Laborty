using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratoryMS_Shehzad.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryMS_Shehzad.Core.Data
{
    public class MyDbContext : DbContext
    {
        
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestPrice> TestPrices { get; set; }
        public DbSet<TblTesting> TblTestings { get; set; }
    }
}
