﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using databaseOtters.Model;

namespace databaseOtters.Pages
{
    public class IndexModel : PageModel
    {
        private readonly databaseOtters.Model.OtterDbContext _context;

        public IndexModel(databaseOtters.Model.OtterDbContext context)
        {
            _context = context;
        }

        public IList<Otter> Otter { get;set; }

        public async Task OnGetAsync()
        {
            Otter = await _context.Otters
                .Include(o => o.Founder)
                .Include(o => o.Mother)
                .Include(o => o.Place).ToListAsync();
        }
    }
}
