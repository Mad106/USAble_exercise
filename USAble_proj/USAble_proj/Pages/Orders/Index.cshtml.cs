using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using USAble_proj.Data;

namespace USAble_proj.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly USAble_proj.Data.USAble_projContext _context;

        public IndexModel(USAble_proj.Data.USAble_projContext context)
        {
            _context = context;
        }

        public IList<Orders> Orders { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Orders != null)
            {
                Orders = await _context.Orders.ToListAsync();
            }
        }
    }
}
