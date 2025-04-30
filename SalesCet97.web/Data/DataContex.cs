using Microsoft.EntityFrameworkCore;
using SalesCet97.web.Data.Entities;

namespace SalesCet97.web.Data
{
    public class DataContex : DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
    }
}
