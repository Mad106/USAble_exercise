using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using USAble_proj1.Models;

namespace USAble_proj1.Data
{
    public class USAble_proj1Context : DbContext
    {
        public USAble_proj1Context (DbContextOptions<USAble_proj1Context> options)
            : base(options)
        {
        }

        public DbSet<USAble_proj1.Models.Order>? Order { get; set; }
    }
}
