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
    [Required]
    public required Guid CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public CategoryEntity Category { get; set; } = null!;
}