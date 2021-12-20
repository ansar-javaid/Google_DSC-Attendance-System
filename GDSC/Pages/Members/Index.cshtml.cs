using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GDSC.Data;
using GDSC.Models;

namespace GDSC.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly GDSC.Data.ApplicationDbContext _context;

        public IndexModel(GDSC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        public async Task OnGetAsync()
        {
            Member = await _context.Member
                .Include(m => m.Event).ToListAsync();
        }
    }
}
