using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public class CategoryEntity : IEntity
{
    public Guid Id { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
    [MaxLength(2048)]
    public string? ImgUrl { get; set; }
    public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
    public Guid? ParentId { get; set; }
    [ForeignKey(nameof(ParentId))]
    public CategoryEntity? Parent { get; set; }

    public ICollection<CategoryEntity> SubCategories { get; set; } = new List<CategoryEntity>();
    public ICollection<AttributeEntity> Attributes { get; set; } = new List<AttributeEntity>();
}