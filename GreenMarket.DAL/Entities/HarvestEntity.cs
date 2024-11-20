using System.ComponentModel.DataAnnotations.Schema;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public record HarvestEntity : IEntity
{
    public Guid Id { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid ProductId { get; set; }
    [ForeignKey(nameof(ProductId))] 
    public ProductEntity Product { get; set; } = null!;

    public ICollection<UserEntity> Participants { get; set; } = [];
}