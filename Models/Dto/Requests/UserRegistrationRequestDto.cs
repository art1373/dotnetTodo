using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models.Dto.Requests
{
    public class UserRegistrationRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
