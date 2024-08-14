using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Purchase
    {
        public int ID { get; set; }
        public DateTime PurchaseDate { get; set; }



        [ForeignKey("Client")]
        public int? ClientID { get; set; }
        public Client? Client { get; set; }

        [ForeignKey("Car")]
        public int? CarID { get; set; }
        public Car? Car { get; set; }



        public Admin? Admin { get; set; }
    }
}
