using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using USAble_proj1.Data;
using USAble_proj1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace USAble_proj1.Pages.Orders
{
    public class All_OrdersModel : PageModel
    {
        private readonly USAble_proj1.Data.USAble_proj1Context _context;
        public All_OrdersModel(USAble_proj1.Data.USAble_proj1Context context)
        {
            _context = context;
        }
        public IList<Order> Order { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Order != null)
            {
                Order = await _context.Order.ToListAsync();
            }
        }
        
    }
}
