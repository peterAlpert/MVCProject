using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Year { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public string ImageURL { get; set; }
        public int EngineCapacity { get; set; }


        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("Admin")]
        public int? AdminID { get; set; }
        public Admin? Admin { get; set; }


        public List<Purchase>? Purchases { get; set; }
    }
}
