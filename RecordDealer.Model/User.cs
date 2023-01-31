using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordDealer.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [MinLength(20)]
        public string Password { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}
