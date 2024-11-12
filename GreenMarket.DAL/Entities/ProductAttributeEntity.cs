using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public class ProductAttributeEntity : IEntity
{
    public Guid Id { get; set; }

    [MaxLength(100)]
    public string? Value { get; set; }
    
    [Required]
    public required Guid ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public ProductEntity Product { get; set; } = null!;

    [Required]
    public required Guid AttributeId { get; set; }
    [ForeignKey(nameof(AttributeId))]
    public AttributeEntity Attribute { get; set; } = null!;
}