using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoreMVC.Models
{
    public class Membership
    {
       
        [Key]
        public int MID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer? Cust { get; set; }
        [ForeignKey("MembershipFee")]
        public int MembershipTypeID { get; set; }
        public MembershipFee? MembershipFee { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime MembershipTime { get; set; }

    }
    
}
