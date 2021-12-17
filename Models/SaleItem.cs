using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    /// <summary>
    /// This class will be used to map the sale items with database
    /// </summary>
    public class SaleItem
    {
        [Key]
        public int SaleID { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string SaleName { get; set; }
        [Required]
        public int StartDate { get; set; }
        [Required]
        public int EndDate { get; set; }
        
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

    }
}
