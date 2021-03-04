using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

    //    [HttpGet("getall")]
    //    public IActionResult GetAll()
    //    {
    //        var result = _userService.GetAll();
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpGet("getbyid")]
    //    public IActionResult GetById(int id)
    //    {
    //        var result = _userService.Get(id);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpPost("add")]
    //    public IActionResult Add(Users user)
    //    {
    //        var result = _userService.Add(user);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpPost("delete")]
    //    public IActionResult Delete(Users user)
    //    {
    //        var result = _userService.Delete(user);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }

    //    [HttpPost("update")]
    //    public IActionResult Update(Users user)
    //    {
    //        var result = _userService.Update(user);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest(result);
    //    }
    }
}
