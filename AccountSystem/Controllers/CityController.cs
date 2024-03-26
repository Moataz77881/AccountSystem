using AccountSystem.Model.DTOs.CityDTO;
using Accountystem.Business.Services.Cities;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> CreateCity([FromBody] CityCreationDto city) 
        {
            await service.CreateCityService(city);
            return Ok("City Added");
        }
        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            return Ok(await service.GetAllCityService());
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCity([FromRoute] int id)
        {
            var result = await service.DeleteCityService(id);
            if(result == null) return NotFound();
            return Ok("City Deleted");
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateCity([FromRoute] int id, [FromBody] CityCreationDto city)
        {
            var result = await service.UpdateCityService(city, id);
            if(result == null) return NotFound();
            return Ok("City Updated");
        }
    }
}
