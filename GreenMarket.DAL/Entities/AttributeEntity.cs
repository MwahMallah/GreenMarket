﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Entities;

public record AttributeEntity : IEntity
{
    public Guid Id { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
    public bool IsRequired { get; set; } = false;
    [Required]
    public required Guid CategoryId { get; set; }
    [JsonIgnore]
    public CategoryEntity Category { get; set; } = null!;

    public ICollection<ProductAttributeEntity> Products { get; set; } = new List<ProductAttributeEntity>();
}