using ECommerceAPI.Entities;

namespace ECommerceAPI.DTOs;
public class OrderAddDto
{
    public Guid UserId { get; set; }
    public IList<OrderDetail> OrderDetails { get; set; }
    public OrderAddDto()
    {
        OrderDetails = new List<OrderDetail>();
    }
}