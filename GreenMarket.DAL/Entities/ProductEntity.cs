using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public record ProductEntity : IEntity
{
    public Guid Id { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
    [MaxLength(5000)]
    public string? Description { get; set; }
    public string? ImgUrl { get; set; }
    public ProductSalesType Type { get; set; } = ProductSalesType.PerUnit;
    public int Stock { get; set; } = 0;
    [Required]
    public required Guid CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public CategoryEntity Category { get; set; } = null!;
    [Required]
    public required Guid CreatorId { get; set; }
    [ForeignKey(nameof(CreatorId))]
    public UserEntity Creator { get; set; } = null!;
    public ICollection<ProductAttributeEntity> Attributes { get; set; } = new List<ProductAttributeEntity>();
    public ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    public ICollection<HarvestEntity> Harvests { get; set; } = new List<HarvestEntity>();
}