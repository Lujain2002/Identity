using System.ComponentModel.DataAnnotations;

namespace IdentityTask.Models.ModelView
{
    public class ModelViewRegister
    {

        [Required]

        public string userName { get; set; }
        [Required]
        [EmailAddress]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }
    }
}
