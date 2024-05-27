using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft_Part2.Models
{
    public class Order
    {

        public int OrderID { get; set; }

        public int UserIdentification { get; set; } 

        public int SellerIdentification { get; set; }

        public int ProductIdentification { get; set; }

        //public User UserIdentification { get; set; }

        //public Seller SellerIdentification { get; set; }

        //public Product ProductIdentification { get; set; }

    }
}
