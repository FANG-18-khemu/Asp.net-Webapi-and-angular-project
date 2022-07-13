using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    public class SeedType
    {
        [Key]
        public int Seedid { get; set; }

        [Required]
        [StringLength(20)]
        public string SeedName { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public bool Availablity { get; set; }

        [ForeignKey("Seedvender")]
        public int SVenderid { get; set; }

        public virtual SeedVender Seedvender { get; set; }

    }
}