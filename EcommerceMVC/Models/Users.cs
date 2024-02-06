namespace EcommerceMVC.Models
{
    public class Users
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime CreatedDate { get; set; }
        public bool Isactive { get; set; }

        public string Password { get; set; }
    }
}
