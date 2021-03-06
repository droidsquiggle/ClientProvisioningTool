
using Microsoft.EntityFrameworkCore;
using ClientProvisioningTool.API.Models;

namespace ClientProvisioningTool.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values {get; set;}
    }
}