using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Service.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        }
        public MySQLContext(DbContextOptions<MySQLContext> options)
        :   base( options )
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}