using AccountSystem.Model.DTOs.CityDTO;
using Accountystem.Business.Services.Cities;
using Microsoft.AspNetCore.Mvc;

namespace AccountSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService service;

        public CityController(ICityService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult CreateCity([FromBody] CityCreationDto city) 
        {
            service.CreateCityService(city);
            return Ok("city Added");
        }
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(service.GetAllCityService());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteCity([FromRoute] int id)
        {
            service.DeleteCityService(id);
            return Ok("city Deleted");
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateCity([FromRoute] int id, [FromBody] CityCreationDto city)
        {
            service.UpdateCityService(city, id);
            return Ok("city Updated");
        }
    }
}
