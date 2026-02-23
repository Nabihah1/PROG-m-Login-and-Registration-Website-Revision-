using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROG_m_Register_LoginRevisionWebsite.Models;

namespace PROG_m_Register_LoginRevisionWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PROG_m_Register_LoginRevisionWebsite.Models.Event> Event { get; set; } = default!;
    }
}
