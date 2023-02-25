using Microsoft.EntityFrameworkCore;

namespace KoreMVC.Models
{
    public class Customer
    {
        
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }

    }
}
