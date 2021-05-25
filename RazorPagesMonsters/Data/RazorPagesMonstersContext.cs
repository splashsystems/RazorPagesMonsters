using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonsters.Models;

namespace RazorPagesMonsters.Data
{
    public class RazorPagesMonstersContext : DbContext
    {
        public RazorPagesMonstersContext (DbContextOptions<RazorPagesMonstersContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMonsters.Models.Monster> Monster { get; set; }
    }
}
