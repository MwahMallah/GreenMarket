using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public record OrderEntity : IEntity
{
    public Guid Id { get; set; }

    [Required]
    public required int Amount { get; set; }
    public float? Rating { get; set; }
    [Required]
    public required Guid UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public UserEntity User { get; set; } = null!;
    public OrderStatus Status { get; set; } = OrderStatus.Active;
    
    [Required]
    public required Guid ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public ProductEntity Product { get; set; } = null!;
}