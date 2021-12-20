using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GDSC.Data;
using GDSC.Models;

namespace GDSC.Pages.Attendaces
{
    public class DetailsModel : PageModel
    {
        private readonly GDSC.Data.ApplicationDbContext _context;

        public DetailsModel(GDSC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Attendence Attendence { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendence = await _context.Attendence
                .Include(a => a.Event).FirstOrDefaultAsync(m => m.Id == id);

            if (Attendence == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
