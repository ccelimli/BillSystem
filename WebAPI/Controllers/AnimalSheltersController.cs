using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/animalshelters")]
    [ApiController]
    public class AnimalSheltersController : ControllerBase
    {
        IAnimalShelterService _animalShelterService;

        public AnimalSheltersController(IAnimalShelterService animalShelterService)
        {
            _animalShelterService = animalShelterService;
        }

        //Add
        [HttpPost("add")]
        public IActionResult Add(AnimalShelter animalShelter)
        {
            var result = _animalShelterService.Add(animalShelter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(AnimalShelter animalShelter)
        {
            var result = _animalShelterService.Delete(animalShelter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //GetAnimalSheltersDetails
        [HttpGet("getanimalshelterdetails")]
        public IActionResult GetAnimalShelterDetails()
        {
            var result = _animalShelterService.GetAnimalShelterDetails();
            if (result.Data.Count == 0)
            {
                return BadRequest(Messages.NotFoundaData);
            }
            else
            {
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
        }

        //GetAll
        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var result = _animalShelterService.GetAll();
            if (result.Data.Count == 0)
            {
                return BadRequest(Messages.NotFoundaData);
            }
            else
            {
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
        }

        //GetById
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result=_animalShelterService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //Update
        [HttpPut("update")]
        public IActionResult Update(AnimalShelter animalShelter)
        {
            var result = _animalShelterService.Update(animalShelter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
