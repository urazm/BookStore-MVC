using System.ComponentModel.DataAnnotations;

namespace SemesterWork.BookStore.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Введите email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Повторите введённый пароль")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
