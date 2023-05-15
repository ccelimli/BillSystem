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
        [HttpDelete("delete")]
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

        //GetDetails
        [HttpGet("getbilldetails")]
        public IActionResult GetBillDetails()
        {
            var result=_billService.GetBillDetails();
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

        //GetByCategoryId
        [HttpGet("getbycategoryid")]
        public IActionResult GetCategoryById(int categoryId)
        {
            var result = _billService.GetCategoryById(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //GetDetailByCategoryId
        [HttpGet("getdetailbycategoryid")]
        public IActionResult GetDetailByCategoryId(int categoryId)
        {
            var result=_billService.GetBillDetailsByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        //Update
        [HttpPut("update")]
        public IActionResult Update(Bill bill)
        {
            var result= _billService.Update(bill);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
