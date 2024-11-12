using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public record UserOrderEntity : IEntity
{
    public Guid Id { get; set; }

    [MaxLength(100)]
    public int Amount { get; set; }
    
    [Required]
    public required Guid UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public UserEntity User { get; set; } = null!;

    [Required]
    public required Guid ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public ProductEntity Product { get; set; } = null!;
}