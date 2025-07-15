using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace NuvemBlue.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cadastro> Cadastros { get; set; }

    }
}
