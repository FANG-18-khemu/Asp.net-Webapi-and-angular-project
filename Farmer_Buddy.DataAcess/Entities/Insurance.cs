using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    public class Insurance
    {
        [Key]
        public int InsuranceId { get; set; }

        [Required]
        [StringLength(20)]
        public string InsuranceName { get; set; }

        [Required]
        public int InsuranceDurationInMonth { get; set; }

        [Required]
        public int Max_Refund { get; set; }

        [Required]
        public int InsurancePremiumPerMonth { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

       public virtual User User { get; set; }
    }
}