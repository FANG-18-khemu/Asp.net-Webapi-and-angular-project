using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    public class PesticideVender
    {
        [Key]
        public int PesticideVenderId { get; set; }
        
        [Required]
        [StringLength(20)]
        public string PesticideVenderName { get; set; }

        [Required]
        [StringLength(30)]
        public string PesticdeVenderShopName { get; set; }

        [Required]
        public long PesticdeVenderPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string PesticdeVenderAddress { get; set; }

        [Required]
        [StringLength(20)]
        public string PesticdeVenderLocation { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

    }
}