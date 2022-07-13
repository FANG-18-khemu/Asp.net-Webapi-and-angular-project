using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    
    public class SeedVender
    {
        [Key]
        public int SeedVenderId { get; set; }

        [Required]
        [StringLength(30)]
        public string SeedvenderName { get; set; }

        [Required]
        [StringLength(50)]
        public string SeedvenderShopName { get; set; }

        [Required]
        public long SeedVendorPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string SeedVendorAddress { get; set; }

        [Required]
        [StringLength(20)]
        public string SeedVendorLocation { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}