using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DamienGuytonMVC.Models
{
    public class SweepstakesDbContext : DbContext
    {
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}