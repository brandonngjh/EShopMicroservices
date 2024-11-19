using BuildingBlocks.Pagination;
using Ordering.Application.Orders.Queries.GetOrdersByCustomer;

namespace Ordering.Application.Orders.Queries.GetOrders;
public record GetOrdersQuery(PaginationRequest PaginationRequest)
    : IQuery<GetOrdersResult>;

public record GetOrdersResult(PaginatedResult<OrderDto> Orders);