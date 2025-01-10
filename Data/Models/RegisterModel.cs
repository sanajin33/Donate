using System.ComponentModel.DataAnnotations;

namespace Donate.Data.Models;

public class RegisterModel
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; } = "";

    [Required]
    public string Role { get; set; } = "";

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; } = "";

    [Phone(ErrorMessage = "Not valid as phone number.")]
    [Display(Name = "Phone")]
    public string PhoneNumber { get; set; } = "";

    [Display(Name = "Address")]
    public string Address { get; set; } = "";

    public string MissionStatement { get; set; } = string.Empty;

    [Required]
    [StringLength(100, ErrorMessage = "Not valid password.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = "";

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password do not match.")]
    public string ConfirmPassword { get; set; } = "";

}