using System.ComponentModel.DataAnnotations;

namespace GreenMarket.Models;

public record AccountViewModel
{
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
}