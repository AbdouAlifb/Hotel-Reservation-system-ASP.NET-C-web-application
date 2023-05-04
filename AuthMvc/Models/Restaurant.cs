
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AuthMvc.Models
{
  

        public class Restaurant
        {
            [Key]
            public int IdMeal { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public string Type{ get; set; }
            [Required]
            public string Price { get; set; }
            [Required]
            public string image { get; set; }
            public ICollection<Restaurant> meals { get; set; }
    }

    public enum Categories
    {
         Dinner,Breakfast, Lunch
    }
}
