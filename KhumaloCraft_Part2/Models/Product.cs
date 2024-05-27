using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft_Part2.Models
{
    public class Product
    { 
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Availability { get; set; }

        public ICollection<Order> ProductX { get; set; }

    }
}
