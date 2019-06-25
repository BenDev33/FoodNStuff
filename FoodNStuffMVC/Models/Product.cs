using System.ComponentModel.DataAnnotations;

namespace FoodNStuffMVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        [Display(Name = "# in Stock")]
        public int InventoryCount { get; set; }

        [Required]
        public decimal Price { get; set; }


        [Required]
        [Display(Name = "Is it food?")]
        public bool IsFood { get; set; }
    }
}