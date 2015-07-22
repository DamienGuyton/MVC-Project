using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DamienGuytonMVC.Models
{
    public class Horse
    {
        public int HorseID { get; set; }
        public string Name { get; set; }
        public int Placing { get; set; }
        public virtual Player Player { get; set; }
    }
}