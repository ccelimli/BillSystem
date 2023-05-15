using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FagsController : ControllerBase
    {
        IFaqService _fagService;

        public FagsController(IFaqService fagService)
        {
            _fagService = fagService;
        }

        //Add
        [HttpPost("add")]
        public IActionResult Add(Faq fag)
        {
            var result = _fagService.Add(fag);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //Delete
        [HttpDelete("delete")]
        public IActionResult Delete(Faq fag)
        {
            var result = _fagService.Delete(fag);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //GetAll
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _fagService.GetAll();
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
            var result = _fagService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //Update
        [HttpPut("update")]
        public IActionResult Update(Faq fag)
        {
            var result=_fagService.Update(fag);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
