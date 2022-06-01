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
    public class DeleteModel : PageModel
    {
        private readonly USAble_proj.Data.USAble_projContext _context;

        public DeleteModel(USAble_proj.Data.USAble_projContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Orders Orders { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders.FirstOrDefaultAsync(m => m.ID == id);

            if (orders == null)
            {
                return NotFound();
            }
            else 
            {
                Orders = orders;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }
            var orders = await _context.Orders.FindAsync(id);

            if (orders != null)
            {
                Orders = orders;
                _context.Orders.Remove(Orders);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
