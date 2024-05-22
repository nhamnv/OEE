using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Entity;

namespace Repository
{
    public class AppDBContext : IdentityDbContext<ApplicationUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> option) : base(option)
        {

        }

        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<Data_Menu> Data_Menus { get; set; }
    }
}
