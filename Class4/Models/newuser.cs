using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class4.Models
{
    public class newuser
    {
        [Key]
        [Required(ErrorMessage = "please fill your Name")]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "please fill your Gender")]
        public string UserGender { get; set; }

        [Required(ErrorMessage = "please fill your Email")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "please fill your Phone")]
        public string UserNumber { get; set; }

        [Required(ErrorMessage = "please fill your Password")]
        [StringLength(7,ErrorMessage ="Pasword not over 7 text")]
        public string Password { get; set; }

        [Required(ErrorMessage = "please fill confirm your password")]
        [Compare("Password",ErrorMessage ="Password not same ")]
        public string PasswordAgian { get; set; }
    }
}
