using DotNetCoreVer1.Data;
using DotNetCoreVer1.Infrastructure;
using DotNetCoreVer1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DotNetCoreVer1.Data 
{
    public class TestResultContext : DbContext 
    {

        private IConfiguration Configuration { get; }

        public TestResultContext () : base () 
        {
            Configuration = ServiceLocator.Current.GetInstance<IConfiguration> ();
        }

        public TestResultContext (IConfiguration configuration) : base () 
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite (Configuration.GetConnectionString ("TestResultContext"));
        }

        public DbSet<TestingResult> TestingResult { get; set; }

    }
}