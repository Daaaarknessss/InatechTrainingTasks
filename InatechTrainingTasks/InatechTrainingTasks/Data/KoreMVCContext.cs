using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KoreMVC.Models;

namespace KoreMVC
{
    public class KoreMVCContext : DbContext
    {
        public KoreMVCContext (DbContextOptions<KoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<KoreMVC.Models.Customer> Customer { get; set; } = default!;

        public DbSet<KoreMVC.Models.Membership> Membership { get; set; }

        public DbSet<KoreMVC.Models.MembershipFee> MembershipFee { get; set; }
    }
}
