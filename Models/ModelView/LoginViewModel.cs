using System.ComponentModel.DataAnnotations;

namespace IdentityTask.Models.ModelView
{
    public class LoginViewModel
    {
        [Required]

        public string userName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool rememberMe { get; set; }
    }
}
