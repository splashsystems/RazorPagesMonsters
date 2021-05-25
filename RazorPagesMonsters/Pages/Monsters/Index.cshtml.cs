using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonsters.Data;
using RazorPagesMonsters.Models;

namespace RazorPagesMonsters.Pages.Monsters
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMonsters.Data.RazorPagesMonstersContext _context;

        public IndexModel(RazorPagesMonsters.Data.RazorPagesMonstersContext context)
        {
            _context = context;
        }

        public IList<Monster> Monster { get;set; }

        public async Task OnGetAsync()
        {
            Monster = await _context.Monster.ToListAsync();
        }
    }
}
