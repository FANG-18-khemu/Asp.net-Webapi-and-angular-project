using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{  
   
    public class MarketPrice
    {
        [Key]
        public int MarketId { get; set; }

        [Required]
        public int MPrice { get; set; }

        [Required]
        public string MarketLocation { get; set; }

        [ForeignKey("CropDetails")]
        public int Cropid { get; set; }

        public CropDetail CropDetails { get; set; }
    }
}