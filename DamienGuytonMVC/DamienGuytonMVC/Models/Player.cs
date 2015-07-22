using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace DamienGuytonMVC.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        [Required(ErrorMessage = "The first name field is required.")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The last name field is required.")]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        public Horse Horse { get; set; }
    }
}