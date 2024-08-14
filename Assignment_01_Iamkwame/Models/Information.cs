using Assignment_01_Iamkwame.Components;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Assignment_01_Iamkwame.Models
{
    public class Information
    {

        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; } 

       
    }
}
