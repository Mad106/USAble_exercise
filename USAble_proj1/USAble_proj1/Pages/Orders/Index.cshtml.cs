using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using USAble_proj1.Data;
using USAble_proj1.Models;

namespace USAble_proj1.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly USAble_proj1.Data.USAble_proj1Context _context;

        public IndexModel(USAble_proj1.Data.USAble_proj1Context context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Order != null)
            {
                Order = await _context.Order.ToListAsync();
            }
        }
    }
}
