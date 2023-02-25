using Microsoft.Build.ObjectModelRemoting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoreMVC.Models
{
    public class MembershipFee
    {
        //[ForeignKey("Membership")]
        //public int MembershipID { get; set; }
        //public Membership Membership { get; set; }
       [Key]
       public int MembershiptypeID { get; set; }
       public string ? MembershipCategory { get; set; }

       public int Fee { get; set; } 

        
    }
}
