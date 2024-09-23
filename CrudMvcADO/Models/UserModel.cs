using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudMvcADO.Models
{
    public class UserModel
    {
        [Display(Name = "USer Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [Display(Name="USer Name")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "USer Email")]
        [EmailAddress(ErrorMessage ="Enter valid email")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "USer Age")]
        [Range(18,70,ErrorMessage ="Age must be beteen 18 to 70")]
        public int Age { get; set; }


    }
}