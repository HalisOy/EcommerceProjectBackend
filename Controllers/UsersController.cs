using Microsoft.AspNetCore.Mvc;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Controllers;

[Route("api/[controller]")]
public class UsersController : Controller
{
    private IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(_userRepository.GetAll());
    }

    [HttpGet("GetById/{id}")]
    public IActionResult Get(Guid id)
    {
        return Ok(_userRepository.Get(predicate: user => user.Id == id));
    }

    [HttpPost("Add")]
    public IActionResult Add([FromBody] User user)
    {
        return Ok(_userRepository.Add(user));
    }

    [HttpPut("Update")]
    public IActionResult Update([FromBody] User user)
    {
        return Ok(_userRepository.Update(user));
    }

    [HttpDelete("DeleteById/{id}")]
    public IActionResult Delete(Guid id)
    {
        var user = _userRepository.Get(predicate: user => user.Id == id);
        if (user == null) return BadRequest("User not found");
        return Ok(_userRepository.Delete(user));
    }
}
