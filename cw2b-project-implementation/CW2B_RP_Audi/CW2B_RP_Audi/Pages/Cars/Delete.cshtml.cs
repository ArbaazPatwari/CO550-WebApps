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
    public class DeleteModel : PageModel
    {
        private readonly CW2B_RP_Audi.Data.ApplicationDbContext _context;

        public DeleteModel(CW2B_RP_Audi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Car == null)
            {
                return NotFound();
            }
            var car = await _context.Car.FindAsync(id);

            if (car != null)
            {
                Car = car;
                _context.Car.Remove(Car);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
