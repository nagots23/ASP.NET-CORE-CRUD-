using Microsoft.EntityFrameworkCore;
using MyCRUD_MVC.Entities;

namespace MyCRUD_MVC.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}