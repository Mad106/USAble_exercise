using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using USAble_proj.Pages.Orders;

namespace USAble_proj.Data
{
    public class USAble_projContext : DbContext
    {
        public USAble_projContext (DbContextOptions<USAble_projContext> options)
            : base(options)
        {
        }

        public DbSet<USAble_proj.Pages.Orders.Orders>? Orders { get; set; }

    }
}
