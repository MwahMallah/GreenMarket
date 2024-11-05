using System.ComponentModel.DataAnnotations;
using GreenMarket.DAL.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Entities;

[Index(nameof(Username), IsUnique = true)]
public class UserEntity : IEntity
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    public string? Name { get; set; }
    
    [Required]
    [MaxLength(30)]
    public required string Username { get; set; }
    public string? Password { get; set; }
}