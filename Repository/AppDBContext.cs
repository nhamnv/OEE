using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AppDBContext: IdentityDbContext<ApplicationUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> option):base(option)
        {
            
        }

        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<Data_Menu> Data_Menus { get; set; }
    }
}
