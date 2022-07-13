using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    public class ReliefFund
    {
        [Key]
        public int ReliefId { get; set; }

        [Required,StringLength(40)]
        public string ReliefReason { get; set; }

        [Required,StringLength(20)]
        public string ReliefLocation { get; set; }

        [Required]
        public bool ReliefStatus { get; set; }

        [Required]
        public int ReliefAmount { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}