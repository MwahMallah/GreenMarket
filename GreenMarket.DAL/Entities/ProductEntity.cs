using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    [Required]
    public required Guid CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public CategoryEntity Category { get; set; } = null!;

    public ICollection<ProductAttributeEntity> Attributes { get; set; } = new List<ProductAttributeEntity>();
}