using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmerbuddyWebApi.Models
{
    public enum UserType {
        Admin,User
    }

 
    public class User
    {
        [Key]
        public int LoginId { get; set; }
        
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required,StringLength(30)]
        public string Email { get; set; }

      
        public UserType UserType { get; set; }

        [Required]
        public string Address { get; set; }


    }
}