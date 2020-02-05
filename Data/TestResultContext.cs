using DotNetCoreVer1.Models;
using DotNetCoreVer1.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreVer1.Data {
    public class TestResultContext : DbContext {

        

        public TestResultContext(){
        }

        public TestResultContext (DbContextOptions<TestResultContext> options) : base (options) { }
        public DbSet<TestingResult> TestingResult { get; set; }

            
    }
}