using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DamienGuytonMVC.Models
{
    public class DatabaseInit : DropCreateDatabaseAlways<SweepstakesDbContext>
    {
        protected override void Seed(SweepstakesDbContext context)
        {
            var Horses = new List<Horse>
            {
                new Horse{Name="American",Placing=4},
                new Horse{Name="Jukebox Jury",Placing=20},
                new Horse{Name="Dunaden",Placing=1},
                new Horse{Name="Drunken Sailor",Placing=12},
                new Horse{Name="Glass Harmonium",Placing=22},
                new Horse{Name="Manighar",Placing=5},
                new Horse{Name="Unusual Suspect",Placing=9},
                new Horse{Name="Fox Hunt",Placing=7},
                new Horse{Name="Lucas Cranach",Placing=3},
                new Horse{Name="Mourayan",Placing=24},
                new Horse{Name="Precedence",Placing=11},
                new Horse{Name="Red Cadeaux",Placing=2},
                new Horse{Name="Hawk Island",Placing=18},
                new Horse{Name="Illo",Placing=19},
                new Horse{Name="Lost in the Moment",Placing=6},
                new Horse{Name="Modun",Placing=23},
                new Horse{Name="At First Sight",Placing=10},
                new Horse{Name="Moyenne Corniche",Placing=15},
                new Horse{Name="Saptapadi",Placing=16},
                new Horse{Name="Shamrocker",Placing=21},
                new Horse{Name="The Verminator",Placing=13},
                new Horse{Name="Tullamore",Placing=14},
                new Horse{Name="Niwot",Placing=8},
                new Horse{Name="Older Than Time",Placing=17},
            };
            foreach (Horse h in Horses)
                context.Horses.Add(h);
            context.SaveChanges();
        }//End of Seed
    }
}