namespace Ordering.Application.Dtos;

public record OrderItemDto(
    Guid OrderId, 
    Guid ProductId, 
    string Quantity, 
    string Price);