using System.ComponentModel.DataAnnotations;

namespace GreenMarket.Models.Account;

public record AccountRegisterViewModel
{
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
    [Required]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public required string PasswordConfirm { get; set; }
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
    public string? Name { get; set; }
}