using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should less than 15 digits")]
        public string Name { get; set; }
        
        [Required]
        [Range(1, 1000, ErrorMessage = "Should have value greater than 0")]
        public float Price { get; set; }

    }
}
