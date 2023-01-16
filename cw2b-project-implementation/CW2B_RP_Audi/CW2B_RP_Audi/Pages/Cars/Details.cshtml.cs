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
    public class DetailsModel : PageModel
    {
        private readonly CW2B_RP_Audi.Data.ApplicationDbContext _context;

        public DetailsModel(CW2B_RP_Audi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Car == null)
            {
                return NotFound();
            }

            var car = await _context.Car.FirstOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }
            else 
            {
                Car = car;
            }
            return Page();
        }
    }
}
