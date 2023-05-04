using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthMvc.Models
{
    public class Reservation
    {
        [Key]
        public int IdReservation { get; set; }
        [ForeignKey("Useraccount")]
        public string UserName { get; set; }
        [ForeignKey("Chambre")]
        public int IdChambre { get; set; }
        [Required]
        public DateTime Date_entrée { get; set; }
        [Required]
        public DateTime Date_sortie { get; set; }
        [Required]
        public int NombrePlace { get; set; }
        public UserAccount Account { get; set; }
        public Chambre Chambre { get; set; }
    }
}
