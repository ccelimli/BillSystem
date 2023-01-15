using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        IBillService _billService;

        public BillsController(IBillService billService)
        {
            _billService = billService;
        }

        //Add
        [HttpPost("add")]
        public IActionResult Add(Bill bill)
        {
            var result = _billService.Add(bill);
            if (result.Success)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }

        //Delete
        [HttpPost("delete")]
        public IActionResult Delete(Bill bill)
        {
            var result = _billService.Delete(bill);
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
            var result = _billService.GetAll();
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
            var result = _billService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
