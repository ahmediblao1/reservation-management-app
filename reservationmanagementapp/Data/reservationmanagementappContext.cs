using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using reservationmanagementapp.Models;

namespace reservationmanagementapp.Data
{
    public class reservationmanagementappContext : DbContext
    {
        public reservationmanagementappContext (DbContextOptions<reservationmanagementappContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<reservationmanagementapp.Models.Room> Room { get; set; } = default!;

        public DbSet<reservationmanagementapp.Models.Instrument> Instrument { get; set; } = default!;
    }
}
