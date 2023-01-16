using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi.Data;
using CW2B_RP_Audi.Models;

namespace CW2B_RP_Audi.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CW2B_RP_Audi.Data.ApplicationDbContext _context;

        public IndexModel(CW2B_RP_Audi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Car != null)
            {
                Car = await _context.Car.ToListAsync();
            }
        }
    }
}
