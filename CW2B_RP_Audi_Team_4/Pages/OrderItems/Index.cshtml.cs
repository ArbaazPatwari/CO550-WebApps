﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Data;
using CW2B_RP_Audi_Team_4.Models;

namespace CW2B_RP_Audi_Team_4.Pages.OrderItems
{
    public class IndexModel : PageModel
    {
        private readonly CW2B_RP_Audi_Team_4.Data.AudiContext _context;

        public IndexModel(CW2B_RP_Audi_Team_4.Data.AudiContext context)
        {
            _context = context;
        }

        public IList<OrderItem> OrderItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OrderItems != null)
            {
                OrderItem = await _context.OrderItems.ToListAsync();
            }
        }
    }
}
