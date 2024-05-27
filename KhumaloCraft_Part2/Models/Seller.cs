using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft_Part2.Models
{
    public class Seller
    {
        public int SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public ICollection<Order> SellerOfX { get; set; }

    }
}
