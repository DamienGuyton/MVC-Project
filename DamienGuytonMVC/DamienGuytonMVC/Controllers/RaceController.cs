using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DamienGuytonMVC.Models;

namespace DamienGuytonMVC.Controllers
{
    public class RaceController : Controller
    {
        // GET: Entrants
        SweepstakesDbContext context = new SweepstakesDbContext();

        private static readonly Double First = 0.5;
        private static readonly Double Second = 0.25;
        private static readonly Double Third = 0.15;
        private static readonly Double Last = 0.10;
        public ActionResult Index()
        {
            //Get all of the horses that were assigned to players.
            List<Horse> horses = GetHorsesAssignedToPlayers();

            if (horses.Count >= 4)//There are enough assigned horses to run the sweepstake.
            {
                ViewBag.WinningColumn = GetWinningColumn(horses);
                return View("RaceSuccess", horses);
            }
            else //Not enough horses to run the sweepstake.
            {
                return View("RaceError", horses);
            }
        }
        private List<Horse> GetHorsesAssignedToPlayers()
        {
            //Get the horses that have 
            return context.Horses.Where(h => h.Player != null).OrderBy(h => h.Placing).ToList();
        }

        private List<String> GetWinningColumn(List<Horse> horses)
        {
            //Make a new list of
            List<String> winningColumns = new List<string>();

            //Calculate the total winnings
            double totalWinnings = horses.Count * 10;

            for (int i = 0; i < horses.Count; i++)
            {
                winningColumns.Add("--");
            }

            //Calculate the distribution of winnings
            winningColumns[0] = "$" + String.Format("{0:0.00}", (totalWinnings * First));
            winningColumns[1] = "$" + String.Format("{0:0.00}", (totalWinnings * Second));
            winningColumns[2] = "$" + String.Format("{0:0.00}", (totalWinnings * Third));
            winningColumns[horses.Count - 1] = "$" + String.Format("{0:0.00}", (totalWinnings * Last));

            return winningColumns;
        }

    }
}
