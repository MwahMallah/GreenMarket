namespace GreenMarket.Responses;

public class CategoryResponse<TEntity>
{
    public required string Type { get; set; }
    public required IEnumerable<TEntity> Payload { get; set; }
}