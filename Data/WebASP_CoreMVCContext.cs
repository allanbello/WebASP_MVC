using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebASP_CoreMVC.Models;

namespace WebASP_CoreMVC.Data
{
    public class WebASP_CoreMVCContext : DbContext
    {
        public WebASP_CoreMVCContext (DbContextOptions<WebASP_CoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebASP_CoreMVC.Models.Departament> Departament { get; set; } = default!;
    }
}
