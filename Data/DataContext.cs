using Microsoft.EntityFrameworkCore;
using PortalApi.Models;

namespace PortalApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options){}
        public DbSet<Value> Values { get; set; }
    }
}