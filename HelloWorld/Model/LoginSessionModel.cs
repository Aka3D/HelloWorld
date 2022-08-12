using System;
using System.ComponentModel.DataAnnotations;
namespace HelloWorld.Model
{
    public class LoginSessionModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
