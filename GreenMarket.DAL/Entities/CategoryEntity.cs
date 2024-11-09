using System.ComponentModel.DataAnnotations;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public class CategoryEntity : IEntity
{
    public Guid Id { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
    public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
}