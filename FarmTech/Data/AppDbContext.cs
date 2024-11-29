using FarmTech.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.Identity.Client;

namespace FarmTech.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        public DbSet<FornecedorModel> Fornecedor { get; set; }
        public DbSet<UserModel> User { get; set; }
        
    }
}
