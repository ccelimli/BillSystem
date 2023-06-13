using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillImagesController : ControllerBase
    {
        IBillImageService _billImageService;

        public BillImagesController(IBillImageService billImageService)
        {
            _billImageService = billImageService;
        }
        
        //Add
        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("image"))] IFormFile file, [FromForm] BillImage billImage)
        {
            var result = _billImageService.Add(file, billImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //Delete
        [HttpDelete("delete")]
        public IActionResult Delete(BillImage billImage)
        {
            var billImageDelete=_billImageService.GetById(billImage.Id).Data;
            var result = _billImageService.Delete(billImageDelete);
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
            var result= _billImageService.GetAll();
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
            var result = _billImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //Update
        [HttpPut("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] BillImage billImage)
        {
            var result = _billImageService.Update(file, billImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
