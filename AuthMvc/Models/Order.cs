using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthMvc.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        [ForeignKey("UserAccount")]
        public int IdClient { get; set; }
        [ForeignKey("Restaurant")]
        public int Idmeal { get; set; }
    }
}
