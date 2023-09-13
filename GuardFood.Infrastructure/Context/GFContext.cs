using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Infrastructure.Context
{
    public class GFContext : IdentityDbContext<ApplicationUser>
    {
        public GFContext(DbContextOptions<GFContext> options) : base(options)
        {
            
        }

        public DbSet<Restaurantes> Restaurantes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
