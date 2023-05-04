using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthMvc.Models
{
    public class Chambre
    {
        public enum Categories
        {
            Famile, Couple, amies
        }
        [Key]
        public int IdChambre { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
		[Required]
        public Categories Categorie { get; set; }
        [Required]
        public int Surface { get; set; }
        [Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }

    
}
