using System.ComponentModel.DataAnnotations;
using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Entities;

[Index(nameof(Username), IsUnique = true)]
public class UserEntity : IEntity
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    public string? Name { get; set; }
    [EmailAddress]
    [Required]
    [MaxLength(100)]
    public required string Email { get; set; }
    [MaxLength(2048)]
    public string? ImgUrl { get; set; }
    [Required]
    [MaxLength(30)]
    public required string Username { get; set; }
    [Required]
    [MaxLength(30)]
    public required string Password { get; set; }
    [Required]
    public required UserRole Role { get; set; }
    public ICollection<UserOrderEntity> Orders { get; set; } = new List<UserOrderEntity>();
    public ICollection<ProductEntity> CreatedProducts { get; set; } = [];
}