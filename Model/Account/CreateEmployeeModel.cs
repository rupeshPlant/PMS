using System.ComponentModel.DataAnnotations;

namespace Models.Account
{
    public class CreateEmployeeModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        [StringLength(50)]
        [RegularExpression(@"[^-\s]",ErrorMessage ="User Name can not contain space")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid email format")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [MaxLength(16, ErrorMessage = "Password cannot be greater than 16 characters.")]
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).*$", ErrorMessage = "Password should be at least 8 characters in length, must contain at least one lowercase letter, one uppercase letter, one digit and a special character e.g: @$!%*#?&")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage =
        "New password and confirmation password do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        [Required]

        public string PhoneNumber { get; set; }

    }
}
