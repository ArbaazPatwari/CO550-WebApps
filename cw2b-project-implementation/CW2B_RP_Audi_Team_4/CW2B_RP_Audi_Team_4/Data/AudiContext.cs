using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Models;

namespace CW2B_RP_Audi_Team_4.Data
{
    public class AudiContext : DbContext
    {
        public AudiContext (DbContextOptions<AudiContext> options)
            : base(options)
        {
        }

        public DbSet<CW2B_RP_Audi_Team_4.Models.Car> Car { get; set; } = default!;
    }
}
