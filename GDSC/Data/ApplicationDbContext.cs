using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GDSC.Models;

namespace GDSC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GDSC.Models.Event> Event { get; set; }
        public DbSet<GDSC.Models.Member> Member { get; set; }
        public DbSet<GDSC.Models.Attendence> Attendence { get; set; }
    }
}
