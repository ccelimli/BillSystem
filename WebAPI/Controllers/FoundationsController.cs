using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoundationsController : ControllerBase
    {
        IFoundationService _foundationService;

        public FoundationsController(IFoundationService foundationService)
        {
            _foundationService = foundationService;
        }

        //Add
        [HttpPost("add")]
        public IActionResult Add(Foundation foundation)
        {
            var result = _foundationService.Add(foundation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //Delete
        [HttpDelete("delete")]
        public IActionResult Delete(Foundation foundation)
        {
            var result = _foundationService.Delete(foundation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //GetAll
        [HttpGet("getall")]
        public IActionResult GetAll(Foundation foundation)
        {
            var result = _foundationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //GetById
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _foundationService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //Update
        [HttpPut("update")]
        public IActionResult Update(Foundation foundation) {
            var result = _foundationService.Update(foundation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
