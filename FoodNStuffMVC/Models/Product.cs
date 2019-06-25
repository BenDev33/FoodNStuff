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
        public int InventoryCount { get; set; }


    }
}