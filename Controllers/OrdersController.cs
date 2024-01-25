using ECommerceAPI.DTOs;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Controllers;
[Route("api/[controller]")]
public class OrdersController : Controller
{
    private readonly IOrderRepository _orderRepository;
    private readonly IOrderDetailRepository _orderDetailRepository;
    private readonly IOrderCancelledRepository _orderCancelledRepository;

    public OrdersController(
        IOrderRepository orderRepository,
        IOrderDetailRepository orderDetailRepository,
        IOrderCancelledRepository orderCancelledRepository
        )
    {
        _orderRepository = orderRepository;
        _orderDetailRepository = orderDetailRepository;
        _orderCancelledRepository = orderCancelledRepository;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(_orderRepository.GetAll());
    }

    [HttpGet("GetAllFillContents")]
    public IActionResult GetAllFillContents()
    {
        return Ok(_orderRepository.GetAll(include: order =>
        order.Include(o => o.OrderDetails).ThenInclude(or=>or.Product)
        .Include(o => o.OrderCancelledes)
            )
        );
    }

    [HttpPost("Add")]
    public IActionResult Add(OrderAddDto orderAddDto)
    {
        if (orderAddDto.OrderDetails.Count() == 0) return BadRequest("Boş ürün gönderilemez.");
        if (orderAddDto.OrderDetails.Where(od => od.Quantity == 0).Any()) return BadRequest("Ürün 0 stok olamaz.");
        //var checkCounts = orderAddDto.OrderDetails.Select(od=>
        //_orderDetailRepository.GetAll(ass=>ass.ProductId==od.ProductId).Sum)
        //return Ok(_orderRepository.Add(order));
        return BadRequest("dön");
    }

    [HttpPut("Update")]
    public IActionResult Update(Order order)
    {
        return Ok(_orderRepository.Update(order));
    }

    [HttpDelete("DeleteById/{id}")]
    public IActionResult Delete(Guid id)
    {
        var order = _orderRepository.Get(predicate: order => order.Id == id);
        if (order == null) BadRequest("Order not found");
        return Ok(_orderRepository.Delete(order));
    }
}
