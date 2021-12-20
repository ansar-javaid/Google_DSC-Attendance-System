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
    public class IndexModel : PageModel
    {
        private readonly GDSC.Data.ApplicationDbContext _context;

        public IndexModel(GDSC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Attendence> Attendence { get;set; }

        public async Task OnGetAsync()
        {
            Attendence = await _context.Attendence
                .Include(a => a.Event).ToListAsync();
        }
    }
}
