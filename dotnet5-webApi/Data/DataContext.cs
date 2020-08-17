using dotnet5_webApi.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnet5_webApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
