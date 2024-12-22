using Ordering.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Dtos
{
    public record OrderDto(Guid Id, Guid CustomerId,string OrderName, AddressDto ShippingAddress,AddressDto BillingAddress,
        PaymentDto Payment,OrderStatus Status,List<OrderItemDto> OrderItems );
}
