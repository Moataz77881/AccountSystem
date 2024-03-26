using AccountSystem.Model.DTOs.CashierDTO;
using Accountystem.Business.Services.CashierServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashierController : ControllerBase
    {
        private readonly ICashierService service;

        public CashierController(ICashierService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CashierCreation([FromBody] CashierCreationDto cashier) 
        {
            var result = await service.CreateCashierService(cashier);
            if (result == null) return NotFound();
            return Ok("Cashier Added");
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCashier()
        {
            return Ok(await service.GetAllCashierService());
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCashier([FromRoute] int id)
        {
            var result = await service.DeleteCashierService(id);
            if (result == null) return NotFound();
            return Ok("Cashier Deleted");
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateCashier([FromRoute] int id, [FromBody] CashierUpdateDto cashier)
        {
            var result = await service.UpdateCashierService(cashier, id);
            if(result == null) return NotFound();
            return Ok("Cashier Updated");
        }
    }
}
