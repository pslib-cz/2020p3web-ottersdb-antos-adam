﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using databaseOtters.Model;

namespace databaseOtters.Pages.Locations
{
    public class IndexModel : PageModel
    {
        private readonly databaseOtters.Model.OtterDbContext _context;

        public IndexModel(databaseOtters.Model.OtterDbContext context)
        {
            _context = context;
        }

        public IList<Location> Location { get;set; }

        public async Task OnGetAsync()
        {
            Location = await _context.Locations.ToListAsync();
        }
    }
}
