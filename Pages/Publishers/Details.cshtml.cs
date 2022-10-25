using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ionescu_Alex_Daniel_Lab2.Data;
using Ionescu_Alex_Daniel_Lab2.Models;

namespace Ionescu_Alex_Daniel_Lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Ionescu_Alex_Daniel_Lab2.Data.Ionescu_Alex_Daniel_Lab2Context _context;

        public DetailsModel(Ionescu_Alex_Daniel_Lab2.Data.Ionescu_Alex_Daniel_Lab2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
