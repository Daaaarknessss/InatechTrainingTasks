using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEF.Models
{
    internal class ProductBatch
    {
        [Key]
        public int BatchId { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        [ForeignKey("ProductFK")]
        public  Product Product { get; set; }

}
}
