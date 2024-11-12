using System.ComponentModel.DataAnnotations;

namespace GreenMarket.Models.Account;

public record AccountRegisterViewModel
{
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
    public string? Name { get; set; }
}