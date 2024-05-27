namespace KhumaloCraft_Part2.Models
{
    public class User
    {

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; }

        public ICollection<Order> OrderFromX { get; set; }

    }
}
