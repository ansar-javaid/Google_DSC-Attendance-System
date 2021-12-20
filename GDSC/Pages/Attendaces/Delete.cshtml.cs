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
    public class DeleteModel : PageModel
    {
        private readonly GDSC.Data.ApplicationDbContext _context;

        public DeleteModel(GDSC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendence = await _context.Attendence.FindAsync(id);

            if (Attendence != null)
            {
                _context.Attendence.Remove(Attendence);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
