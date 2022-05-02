using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppMVC.Models;

namespace AppMVC.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Participantes> Participantes { get; set; }
    }
}