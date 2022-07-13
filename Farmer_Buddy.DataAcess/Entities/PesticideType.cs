using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    public class PesticideType
    {
        [Key]
        public int PesticideId { get; set; }

        [Required]
        [StringLength(30)]
        public string PesticideName { get; set; }

        [Required]
        public bool Availablity { get; set; }

        [Required]
        public int PesticideCost { get; set; }

        [ForeignKey("PesticideVender")]
        public int PVenderId { get; set; }
        
        public virtual PesticideVender PesticideVender { get; set; }

    }
}