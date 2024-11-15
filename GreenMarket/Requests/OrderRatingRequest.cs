namespace GreenMarket.Requests;

public record OrderRatingRequest
{
    public int Rating { get; set; }
    public Guid OrderId { get; set; }
}