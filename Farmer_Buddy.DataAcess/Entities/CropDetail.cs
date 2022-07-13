using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    public class CropDetail
    {
        [Key]
        public int CropId { get; set; }

        [Required]
        [StringLength(20)]
        public string CropName { get; set; }

        [Required]
        [StringLength(20)]
        public string SoilFertility { get; set; }

        [Required]
        public int waterLevel { get; set; }

        [Required]
        [StringLength(20)]
        public string WeatherCondition { get; set; }

        [Required]
        [StringLength(10)]
        public string FertilizerType { get; set; }

        [Required]
        [StringLength(10)]
        public string FertilizerName { get; set; }

        [Required]
        [StringLength(20)]
        public string SoilName { get; set; }

        [ForeignKey("User")]
        public int Userid { get; set; }

        public virtual User User { get; set; }
    }
}