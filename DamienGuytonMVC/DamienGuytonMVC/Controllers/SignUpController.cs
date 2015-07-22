using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DamienGuytonMVC.Models;

namespace DamienGuytonMVC.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        SweepstakesDbContext context = new SweepstakesDbContext();
        Random r = new Random();

        [HttpGet]
        public ActionResult Index()
        {
            return View("SignupForm");
        }

        [HttpPost]
        public ActionResult Index(Player newPlayer)
        {
            if (!ModelState.IsValidField("FirstName") || !ModelState.IsValidField("LastName"))
            {
                return View("SignupForm");
            }
            else
            {
                //Get all of the horses.
                List<Horse> horses = context.Horses.ToList();

                //Get the horses that are available.
                List<Horse> availableHorses = GetAListOfAvailableHorses(horses);

                if (availableHorses.Count > 0)//There is at least one available horse.
                {
                    newPlayer.Horse = PickRandomHorse(availableHorses);
                    context.Players.Add(newPlayer);
                    context.SaveChanges();
                    return View("SignupSuccess", newPlayer);
                }
                else //There are no available horses.
                {
                    return View("SignupError", newPlayer);
                }
            }
        }
        private Horse PickRandomHorse(List<Horse> availableHorses)
        {
            //Randomly select a horse from the list of available horses.
            return availableHorses[r.Next(availableHorses.Count)];
        }

        private List<Horse> GetAListOfAvailableHorses(List<Horse> horses)
        {
            //Get a list of available horses.
            List<Horse> availableHorses = new List<Horse>();
            foreach (Horse h in horses)
                if (h.Player == null)
                    availableHorses.Add(h);

            return availableHorses;
        }
    }
}
