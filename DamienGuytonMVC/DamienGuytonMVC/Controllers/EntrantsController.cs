using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DamienGuytonMVC.Models;

namespace DamienGuytonMVC.Controllers
{
    public class EntrantsController : Controller
    {
        SweepstakesDbContext context = new SweepstakesDbContext();

        public ActionResult Index()
        {
            //Get all of the horses that were assigned to players.
            List<Horse> horses = GetHorsesAssignedToPlayers();

            if (horses.Count >= 1)//There are enough assigned horses to run the sweepstake.
            {
                return View("Entrants", horses);
            }
            else //Not enough horses to run the sweepstake.
            {
                return View("EntrantsError");
            }

        }

        private List<Horse> GetHorsesAssignedToPlayers()
        {
            //Get the horses that have 
            return context.Horses.Where(h => h.Player != null).ToList();
        }       

    }
}
