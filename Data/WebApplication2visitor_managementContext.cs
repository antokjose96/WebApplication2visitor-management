using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2visitor_management.Models;

namespace WebApplication2visitor_management.Data
{
    public class WebApplication2visitor_managementContext : DbContext
    {
        public WebApplication2visitor_managementContext (DbContextOptions<WebApplication2visitor_managementContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2visitor_management.Models.Booking> Booking { get; set; } = default!;

        public DbSet<WebApplication2visitor_management.Models.Class> Class { get; set; } = default!;

        public DbSet<WebApplication2visitor_management.Models.Event> Event { get; set; } = default!;
    }
}
