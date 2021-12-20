using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GDSC.Data;
using GDSC.Models;

namespace GDSC.Pages.Attendaces
{
    public class CreateModel : PageModel
    {
        private readonly GDSC.Data.ApplicationDbContext _context;

        public CreateModel(GDSC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventName");
            return Page();
        }

        [BindProperty]
        public Attendence Attendence { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attendence.Add(Attendence);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
